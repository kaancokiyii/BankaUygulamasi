using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System.Collections.ObjectModel;

// The data model defined by this file serves as a representative example of a strongly-typed
// model that supports notification when members are added, removed, or modified.  The property
// names chosen coincide with data bindings in the standard item WindowsUIViewApplications.
//
// Applications may use this model as a starting point and build on it, or discard it entirely and
// replace it with something appropriate to their needs.

namespace Bankaekran
{
    /// <summary>
    /// Base class for <see cref="SampleDataItem"/> and <see cref="SampleDataGroup"/> that
    /// defines properties common to both.
    /// </summary>
    public class SampleDataCommon
    {
        string subtitleCore, imagePathCore, descriptionCore, titleCore;
        public string Title { get { return titleCore; } }
        public string Subtitle { get { return subtitleCore; } }
        public string ImagePath { get { return imagePathCore; } }
        public string Description { get { return descriptionCore; } }
        public SampleDataCommon(string title, string subtitle, string imagePath, string description)
        {
            titleCore = title;
            subtitleCore = subtitle;
            imagePathCore = imagePath;
            descriptionCore = description;
        }
        public SampleDataCommon() { }
    }
    /// <summary>
    /// Generic item data model.
    /// </summary>
    public class SampleDataItem : SampleDataCommon
    {
        string contentCore, groupNameCore;
        public SampleDataItem(string title, string subtitle, string imagePath, string description, string content, string groupName)
            : base(title, subtitle, imagePath, description)
        {
            contentCore = content;
            groupNameCore = groupName;
        }
        public string Content { get { return contentCore; } }
        public string GroupName { get { return groupNameCore; } }
    }
    /// <summary>
    /// Generic group data model.
    /// </summary>
    public class SampleDataGroup : SampleDataCommon
    {
        string nameCore;
        Collection<SampleDataItem> itemsCore;
        public SampleDataGroup(string name)
            : base()
        {
            this.nameCore = name;
            itemsCore = new Collection<SampleDataItem>();
        }
        public SampleDataGroup(string name, string title, string subtitle, string imagePath, string description)
            : base(title, subtitle, imagePath, description)
        {
            this.nameCore = name;
            itemsCore = new Collection<SampleDataItem>();
        }
        public string Name { get { return nameCore; } }
        public Collection<SampleDataItem> Items { get { return itemsCore; } }
        public bool AddItem(SampleDataItem tile)
        {
            if (!itemsCore.Contains(tile))
            {
                itemsCore.Add(tile);
                return true;
            }
            return false;
        }
    }
    /// <summary>
    /// Generic data model.
    /// </summary>
    class SampleDataModel
    {
        Collection<SampleDataGroup> groupsCore;
        public SampleDataModel()
        {
            groupsCore = new Collection<SampleDataGroup>();
        }
        public Collection<SampleDataGroup> Groups { get { return groupsCore; } }
        SampleDataGroup GetGroup(string name)
        {
            foreach (var group in groupsCore)
                if (group.Name == name) return group;
            return null;
        }
        public bool AddItem(SampleDataItem tile)
        {
            if (tile == null) return false;
            string groupName = tile.GroupName == null ? "" : tile.GroupName;
            SampleDataGroup thisGroup = GetGroup(groupName);
            if (thisGroup == null)
            {
                thisGroup = new SampleDataGroup(groupName);
                groupsCore.Add(thisGroup);
            }
            return thisGroup.AddItem(tile);
        }
        bool ContainsGroup(string name)
        {
            return GetGroup(name) != null;
        }
        public void CreateGroup(string name, string title, string subtitle, string imagePath, string description)
        {
            if (ContainsGroup(name)) return;
            SampleDataGroup group = new SampleDataGroup(name, title, subtitle, imagePath, description);
            groupsCore.Add(group);
        }
    }
    /// <summary>
    /// Creates a collection of groups and items with hard-coded content.
    /// 
    /// SampleDataSource initializes with placeholder data rather than live production
    /// data so that sample data is provided at both design-time and run-time.
    /// </summary>
    class SampleDataSource
    {
        SampleDataModel dataCore;
        public SampleDataSource()
        {
            
        }
        public SampleDataModel Data { get { return dataCore; } }
    }
}
