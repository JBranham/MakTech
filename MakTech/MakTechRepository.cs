﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MakTech
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MakTechRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("dc804836-de0a-4477-b117-bd4735491488")]
    public partial class MakTechRepository : RepoGenBaseFolder
    {
        static MakTechRepository instance = new MakTechRepository();
        MakTechRepositoryFolders.MyAppAppFolder _myapp;

        /// <summary>
        /// Gets the singleton class instance representing the MakTechRepository element repository.
        /// </summary>
        [RepositoryFolder("dc804836-de0a-4477-b117-bd4735491488")]
        public static MakTechRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MakTechRepository() 
            : base("MakTechRepository", "/", null, 0, false, "dc804836-de0a-4477-b117-bd4735491488", ".\\RepositoryImages\\MakTechRepositorydc804836.rximgres")
        {
            _myapp = new MakTechRepositoryFolders.MyAppAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("dc804836-de0a-4477-b117-bd4735491488")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The MyApp folder.
        /// </summary>
        [RepositoryFolder("4d6651fa-a233-444a-9ef9-9aeffce1f2ae")]
        public virtual MakTechRepositoryFolders.MyAppAppFolder MyApp
        {
            get { return _myapp; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MakTechRepositoryFolders
    {
        /// <summary>
        /// The MyAppAppFolder folder.
        /// </summary>
        [RepositoryFolder("4d6651fa-a233-444a-9ef9-9aeffce1f2ae")]
        public partial class MyAppAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _movieInfo;
            RepoItemInfo _genderInfo;
            RepoItemInfo _inputtagaddInfo;
            RepoItemInfo _countInfo;
            RepoItemInfo _clearInfo;

            /// <summary>
            /// Creates a new MyApp  folder.
            /// </summary>
            public MyAppAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MyApp", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "4d6651fa-a233-444a-9ef9-9aeffce1f2ae", "")
            {
                _firstnameInfo = new RepoItemInfo(this, "FirstName", ".//input[#'FirstName']", 30000, null, "47374176-fbb0-41a1-89ea-b6cb457e6969");
                _lastnameInfo = new RepoItemInfo(this, "LastName", ".//input[#'LastName']", 30000, null, "7d46cf50-38d2-48cb-a1f6-0bee68be266d");
                _movieInfo = new RepoItemInfo(this, "Movie", ".//select[#'Category']/option[@value='Movie']", 30000, null, "61b81dfe-f801-40f2-a525-417f4410d1b2");
                _genderInfo = new RepoItemInfo(this, "Gender", ".//td[#'gender']//input[@name='Gender' and @type='radio' and @value='male']", 30000, null, "eb910f0a-356c-4afd-bfe3-21a0f0680625");
                _inputtagaddInfo = new RepoItemInfo(this, "InputTagAdd", ".//input[#'Add']", 30000, null, "3a45fabe-3f67-467f-b55a-e30f7119a504");
                _countInfo = new RepoItemInfo(this, "Count", ".//td[#'count']", 30000, null, "ffc753fa-d7f8-4fe2-b540-8e5d50a6bc73");
                _clearInfo = new RepoItemInfo(this, "Clear", ".//input[#'Clear']", 30000, null, "f6568834-89a1-4a71-91e3-1e4b5ff117a9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4d6651fa-a233-444a-9ef9-9aeffce1f2ae")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4d6651fa-a233-444a-9ef9-9aeffce1f2ae")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("47374176-fbb0-41a1-89ea-b6cb457e6969")]
            public virtual Ranorex.InputTag FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("47374176-fbb0-41a1-89ea-b6cb457e6969")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The LastName item.
            /// </summary>
            [RepositoryItem("7d46cf50-38d2-48cb-a1f6-0bee68be266d")]
            public virtual Ranorex.InputTag LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("7d46cf50-38d2-48cb-a1f6-0bee68be266d")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The Movie item.
            /// </summary>
            [RepositoryItem("61b81dfe-f801-40f2-a525-417f4410d1b2")]
            public virtual Ranorex.OptionTag Movie
            {
                get
                {
                    return _movieInfo.CreateAdapter<Ranorex.OptionTag>(true);
                }
            }

            /// <summary>
            /// The Movie item info.
            /// </summary>
            [RepositoryItemInfo("61b81dfe-f801-40f2-a525-417f4410d1b2")]
            public virtual RepoItemInfo MovieInfo
            {
                get
                {
                    return _movieInfo;
                }
            }

            /// <summary>
            /// The Gender item.
            /// </summary>
            [RepositoryItem("eb910f0a-356c-4afd-bfe3-21a0f0680625")]
            public virtual Ranorex.InputTag Gender
            {
                get
                {
                    return _genderInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Gender item info.
            /// </summary>
            [RepositoryItemInfo("eb910f0a-356c-4afd-bfe3-21a0f0680625")]
            public virtual RepoItemInfo GenderInfo
            {
                get
                {
                    return _genderInfo;
                }
            }

            /// <summary>
            /// The InputTagAdd item.
            /// </summary>
            [RepositoryItem("3a45fabe-3f67-467f-b55a-e30f7119a504")]
            public virtual Ranorex.InputTag InputTagAdd
            {
                get
                {
                    return _inputtagaddInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagAdd item info.
            /// </summary>
            [RepositoryItemInfo("3a45fabe-3f67-467f-b55a-e30f7119a504")]
            public virtual RepoItemInfo InputTagAddInfo
            {
                get
                {
                    return _inputtagaddInfo;
                }
            }

            /// <summary>
            /// The Count item.
            /// </summary>
            [RepositoryItem("ffc753fa-d7f8-4fe2-b540-8e5d50a6bc73")]
            public virtual Ranorex.TdTag Count
            {
                get
                {
                    return _countInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The Count item info.
            /// </summary>
            [RepositoryItemInfo("ffc753fa-d7f8-4fe2-b540-8e5d50a6bc73")]
            public virtual RepoItemInfo CountInfo
            {
                get
                {
                    return _countInfo;
                }
            }

            /// <summary>
            /// The Clear item.
            /// </summary>
            [RepositoryItem("f6568834-89a1-4a71-91e3-1e4b5ff117a9")]
            public virtual Ranorex.InputTag Clear
            {
                get
                {
                    return _clearInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Clear item info.
            /// </summary>
            [RepositoryItemInfo("f6568834-89a1-4a71-91e3-1e4b5ff117a9")]
            public virtual RepoItemInfo ClearInfo
            {
                get
                {
                    return _clearInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
