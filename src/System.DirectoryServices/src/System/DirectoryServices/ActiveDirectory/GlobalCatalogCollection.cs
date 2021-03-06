// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.DirectoryServices.ActiveDirectory
{
    using System;
    using System.Globalization;
    using System.Collections;

    public class GlobalCatalogCollection : ReadOnlyCollectionBase
    {
        internal GlobalCatalogCollection() { }

        internal GlobalCatalogCollection(ArrayList values)
        {
            if (values != null)
            {
                InnerList.AddRange(values);
            }
        }

        public GlobalCatalog this[int index]
        {
            get
            {
                return (GlobalCatalog)InnerList[index];
            }
        }

        public bool Contains(GlobalCatalog globalCatalog)
        {
            if (globalCatalog == null)
                throw new ArgumentNullException("globalCatalog");

            for (int i = 0; i < InnerList.Count; i++)
            {
                GlobalCatalog tmp = (GlobalCatalog)InnerList[i];
                if (Utils.Compare(tmp.Name, globalCatalog.Name) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(GlobalCatalog globalCatalog)
        {
            if (globalCatalog == null)
                throw new ArgumentNullException("globalCatalog");

            for (int i = 0; i < InnerList.Count; i++)
            {
                GlobalCatalog tmp = (GlobalCatalog)InnerList[i];
                if (Utils.Compare(tmp.Name, globalCatalog.Name) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public void CopyTo(GlobalCatalog[] globalCatalogs, int index)
        {
            InnerList.CopyTo(globalCatalogs, index);
        }
    }
}
