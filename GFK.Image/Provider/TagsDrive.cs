﻿using System.Management.Automation;

namespace GFK.Image.Provider
{
    public class TagsDrive : PSDriveInfo
    {
        public TagsDrive(PSDriveInfo driveInfo) : base(driveInfo)
        {
            Repository = new TagsRepository();
        }

        public ITagsRepository Repository { get; }
    }
}