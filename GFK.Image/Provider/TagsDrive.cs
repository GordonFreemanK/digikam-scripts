﻿using System.Management.Automation;

namespace GFK.Image.Provider;

public class TagsDrive : PSDriveInfo
{
    public TagsDrive(PSDriveInfo driveInfo, char itemSeparator) : base(driveInfo)
    {
        Repository = new TagsRepository(driveInfo.Root, itemSeparator);
    }

    public ITagsRepository Repository { get; }
}