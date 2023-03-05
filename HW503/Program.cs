using Azure.Storage.Blobs;

string connStr = "DefaultEndpointsProtocol=https;AccountName=lopatinstorage;AccountKey=/ODnfrHlg66QT2fsuFLvKyr/YTB7OKbOMtr//EMSD/fvNgU7G6XLFeGsRoptNy37gy7pMZlhiI03+AStlq122Q==;EndpointSuffix=core.windows.net";
BlobServiceClient blobSeviceClient = new BlobServiceClient(connStr);

string containerName = "con7a6cc101-cfc0-4a4d-b5a6-b80bb7fb178b";
BlobContainerClient containerClient = blobSeviceClient.GetBlobContainerClient(containerName);

string fileName = "testing.txt";
BlobClient blobClient = containerClient.GetBlobClient(fileName);

if (await blobClient.ExistsAsync())
{
	var result = blobClient.DownloadContentAsync();
	Console.WriteLine(result.Result.Value.Content.ToString());
}
else
{
	Console.WriteLine("Blob client is not found");
}

Console.ReadLine();
