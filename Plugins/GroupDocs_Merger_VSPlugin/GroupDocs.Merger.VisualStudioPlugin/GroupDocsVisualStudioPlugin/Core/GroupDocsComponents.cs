// Copyright (c) Aspose 2002-2016. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GroupDocsMergerVisualStudioPlugin.Core
{
    public class GroupDocsComponents
    {
        public static Dictionary<String, GroupDocsComponent> list = new Dictionary<string, GroupDocsComponent>();
        public GroupDocsComponents()
        {
            list.Clear();

            GroupDocsComponent groupdocsMerger = new GroupDocsComponent();
            groupdocsMerger.set_downloadUrl("");
            groupdocsMerger.set_downloadFileName("groupdocs.Merger.zip");
            groupdocsMerger.set_name(Constants.GROUPDOCS_COMPONENT);
            groupdocsMerger.set_remoteExamplesRepository("https://github.com/groupdocs-Merger/GroupDocs.Merger-for-.NET.git");
            list.Add(Constants.GROUPDOCS_COMPONENT, groupdocsMerger);
        }
    }
}
