using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.IO;
using Adaptive.Intelligence.Shared.Logging;
using System.Security.Cryptography;

namespace Adaptive.Data.Vault;

public sealed class SecureDeleteClient : DisposableObjectBase
{
    public event ProgressUpdateEventHandler StatusUpdate;

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }

    private void OnStatusUpdate(ProgressUpdateEventArgs e)
    {
        try
        {
            this.StatusUpdate?.Invoke(this, e);
        }
        catch (Exception ex)
        {
            ExceptionLog.LogException(ex);
        }
    }

    public async Task SecureDeleteFileAsync(string fileName)
    {
        OnStatusUpdate(new ProgressUpdateEventArgs("Starting...", 0));
        if (SafeIO.FileExists(fileName))
        {
            OnStatusUpdate(new ProgressUpdateEventArgs("Pass 1...", 12));
            await PerformDoDPassOneAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            OnStatusUpdate(new ProgressUpdateEventArgs("Pass 2...", 24));
            await PerformDoDPassTwoAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            OnStatusUpdate(new ProgressUpdateEventArgs("Pass 3...", 36));
            await PerformDoDPassThreeAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            OnStatusUpdate(new ProgressUpdateEventArgs("Pass 4...", 49));
            await PerformDoDPassOneAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            OnStatusUpdate(new ProgressUpdateEventArgs("Pass 5...", 61));
            await PerformDoDPassTwoAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            OnStatusUpdate(new ProgressUpdateEventArgs("Pass 6...", 73));
            await PerformDoDPassThreeAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            OnStatusUpdate(new ProgressUpdateEventArgs("Pass 7...", 86));
            await PerformRandomPassAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            OnStatusUpdate(new ProgressUpdateEventArgs("Pass 8...", 94));
            await PerformDoDPassThreeAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            SafeIO.DeleteFile(fileName);
            await CreateFakeFileAsync(fileName).ConfigureAwait(continueOnCapturedContext: false);
            SafeIO.DeleteFile(fileName);
        }
        OnStatusUpdate(new ProgressUpdateEventArgs("Completed...", 100));
        await Task.Delay(100);
    }

    private async Task PerformDoDPassOneAsync(string fileName)
    {
        long length = SafeIO.GetFileSize(fileName);
        FileStream stream = SafeIO.OpenFileForExclusiveWrite(fileName);
        if (stream != null)
        {
            await WriteDataAsync(stream, length, 0).ConfigureAwait(continueOnCapturedContext: false);
            stream.Flush();
            stream.Dispose();
        }
    }

    private async Task PerformDoDPassTwoAsync(string fileName)
    {
        long length = SafeIO.GetFileSize(fileName);
        FileStream stream = SafeIO.OpenFileForExclusiveWrite(fileName);
        if (stream != null)
        {
            await WriteDataAsync(stream, length, byte.MaxValue).ConfigureAwait(continueOnCapturedContext: false);
            stream.Flush();
            stream.Dispose();
        }
    }

    private async Task PerformDoDPassThreeAsync(string fileName)
    {
        RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] randomChar = new byte[1];
        rng.GetBytes(randomChar);
        long length = SafeIO.GetFileSize(fileName);
        FileStream stream = SafeIO.OpenFileForExclusiveWrite(fileName);
        if (stream != null)
        {
            await WriteDataAsync(stream, length, randomChar[0]).ConfigureAwait(continueOnCapturedContext: false);
            stream.Flush();
            stream.Dispose();
        }
        rng.Dispose();
    }

    private async Task PerformRandomPassAsync(string fileName)
    {
        RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] randomChar = new byte[1];
        rng.GetBytes(randomChar);
        long length = SafeIO.GetFileSize(fileName);
        FileStream stream = SafeIO.OpenFileForExclusiveWrite(fileName);
        if (stream != null)
        {
            await WriteRandomDataAsync(stream, length).ConfigureAwait(continueOnCapturedContext: false);
            stream.Flush();
            stream.Dispose();
        }
        rng.Dispose();
    }

    private async Task CreateFakeFileAsync(string fileName)
    {
        if (File.Exists(fileName))
        {
            SafeIO.DeleteFile(fileName);
        }
        FileStream stream = SafeIO.CreateFileForExclusiveWrite(fileName);
        if (stream != null)
        {
            byte[] randomData = RandomNumberGenerator.GetBytes(5100);
            stream.Write(randomData, 0, randomData.Length);
            stream.Flush();
            stream.Dispose();
        }
    }

    private async Task WriteDataAsync(Stream destinationStream, long length, byte character)
    {
        int blocks = (int)(length / 1024);
        int remainder = (int)(length % 1024);
        byte[] data = new byte[1024];
        byte[] lastBlock = new byte[remainder];
        Array.Fill(data, character);
        Array.Fill(lastBlock, character);
        for (int count = 0; count < blocks; count++)
        {
            await destinationStream.WriteAsync(data, 0, data.Length).ConfigureAwait(continueOnCapturedContext: false);
            await destinationStream.FlushAsync().ConfigureAwait(continueOnCapturedContext: false);
        }
        await destinationStream.WriteAsync(lastBlock, 0, lastBlock.Length);
        await destinationStream.FlushAsync().ConfigureAwait(continueOnCapturedContext: false);
        ByteArrayUtil.Clear(data);
        ByteArrayUtil.Clear(lastBlock);
    }

    private async Task WriteRandomDataAsync(Stream destinationStream, long length)
    {
        int blocks = (int)(length / 1024);
        int remainder = (int)(length % 1024);
        byte[] data = RandomNumberGenerator.GetBytes(1024);
        byte[] lastBlock = RandomNumberGenerator.GetBytes(remainder);
        for (int count = 0; count < blocks; count++)
        {
            await destinationStream.WriteAsync(data, 0, data.Length).ConfigureAwait(continueOnCapturedContext: false);
            await destinationStream.FlushAsync().ConfigureAwait(continueOnCapturedContext: false);
        }
        await destinationStream.WriteAsync(lastBlock, 0, lastBlock.Length);
        await destinationStream.FlushAsync().ConfigureAwait(continueOnCapturedContext: false);
        ByteArrayUtil.Clear(data);
        ByteArrayUtil.Clear(lastBlock);
    }
}
