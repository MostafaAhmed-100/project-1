﻿namespace WebApplication1.Services
{
    public interface IFileServices
    {
        Task<string> SaveFileAsync(IFormFile file, string folderName);
        void DeleteFile(string filePath);
    }
}
