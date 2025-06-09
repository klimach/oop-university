
using System;
using System.IO;
using System.Net;

public static class FtpHelper
{
    public static FtpWebRequest CreateRequest(string url, string user, string pass, string method)
    {
        var request = (FtpWebRequest)WebRequest.Create(url);
        request.Credentials = new NetworkCredential(user, pass);
        request.Method = method;
        request.EnableSsl = false;
        request.UseBinary = true;
        request.UsePassive = true;
        return request;
    }

    public static string[] ListDirectoryDetails(string url, string user, string pass)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.ListDirectoryDetails);
        using var response = (FtpWebResponse)request.GetResponse();
        using var reader = new StreamReader(response.GetResponseStream());
        var list = new System.Collections.Generic.List<string>();

        while (!reader.EndOfStream)
            list.Add(reader.ReadLine());

        return list.ToArray();
    }

    public static string[] ListNames(string url, string user, string pass)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.ListDirectory);
        using var response = (FtpWebResponse)request.GetResponse();
        using var reader = new StreamReader(response.GetResponseStream());
        var list = new System.Collections.Generic.List<string>();

        while (!reader.EndOfStream)
            list.Add(reader.ReadLine());

        return list.ToArray();
    }

    public static void UploadFile(string url, string user, string pass, string localFilePath)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.UploadFile);
        byte[] fileContents = File.ReadAllBytes(localFilePath);
        using var requestStream = request.GetRequestStream();
        requestStream.Write(fileContents, 0, fileContents.Length);
    }

    public static void UploadFileUnique(string url, string user, string pass, string localFilePath)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.UploadFileWithUniqueName);
        byte[] fileContents = File.ReadAllBytes(localFilePath);
        using (var requestStream = request.GetRequestStream())
        {
            requestStream.Write(fileContents, 0, fileContents.Length);
        }
    }

    public static void AppendFile(string url, string user, string pass, string localFilePath)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.AppendFile);
        byte[] fileContents = File.ReadAllBytes(localFilePath);
        using var requestStream = request.GetRequestStream();
        requestStream.Write(fileContents, 0, fileContents.Length);
    }

    public static void DownloadFile(string url, string user, string pass, string localPath)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.DownloadFile);
        using var response = (FtpWebResponse)request.GetResponse();
        using var responseStream = response.GetResponseStream();
        using var outputStream = new FileStream(localPath, FileMode.Create);
        responseStream.CopyTo(outputStream);
    }

    public static void DeleteFile(string url, string user, string pass)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.DeleteFile);
        using var response = (FtpWebResponse)request.GetResponse();
    }

    public static DateTime GetModifiedTime(string url, string user, string pass)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.GetDateTimestamp);
        using var response = (FtpWebResponse)request.GetResponse();
        return response.LastModified;
    }

    public static long GetFileSize(string url, string user, string pass)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.GetFileSize);
        using var response = (FtpWebResponse)request.GetResponse();
        return response.ContentLength;
    }

    public static void CreateDirectory(string url, string user, string pass)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.MakeDirectory);
        using var response = (FtpWebResponse)request.GetResponse();
    }

    public static void RemoveDirectory(string url, string user, string pass)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.RemoveDirectory);
        using var response = (FtpWebResponse)request.GetResponse();
    }

    public static void Rename(string url, string user, string pass, string newName)
    {
        var request = CreateRequest(url, user, pass, WebRequestMethods.Ftp.Rename);
        request.RenameTo = newName;
        using var response = (FtpWebResponse)request.GetResponse();
    }
}
