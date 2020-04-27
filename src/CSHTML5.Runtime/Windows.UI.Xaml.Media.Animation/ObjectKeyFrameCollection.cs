﻿

/*===================================================================================
* 
*   Copyright (c) Userware/OpenSilver.net
*      
*   This file is part of the OpenSilver Runtime (https://opensilver.net), which is
*   licensed under the MIT license: https://opensource.org/licenses/MIT
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
\*====================================================================================*/


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if MIGRATION
namespace System.Windows.Media.Animation
#else
namespace Windows.UI.Xaml.Media.Animation
#endif
{
    /// <summary>
    /// Represents a collection of ObjectKeyFrame objects that can be individually
    /// accessed by index.
    /// </summary>
#if WORKINPROGRESS
    public sealed partial class ObjectKeyFrameCollection : PresentationFrameworkCollection<ObjectKeyFrame>
#else
    public sealed partial class ObjectKeyFrameCollection : List<ObjectKeyFrame> //: IList<ObjectKeyFrame>, IEnumerable<ObjectKeyFrame>
#endif
    {
#if WORKINPROGRESS
        internal override void AddOverride(ObjectKeyFrame keyFrame)
        {
            this.AddInternal(keyFrame);
        }

        internal override void ClearOverride()
        {
            this.ClearInternal();
        }

        internal override void InsertOverride(int index, ObjectKeyFrame keyFrame)
        {
            this.InsertInternal(index, keyFrame);
        }

        internal override void RemoveAtOverride(int index)
        {
            this.RemoveAtInternal(index);
        }

        internal override bool RemoveOverride(ObjectKeyFrame keyFrame)
        {
            return this.RemoveInternal(keyFrame);
        }

        internal override void SetItemOverride(int index, ObjectKeyFrame keyFrame)
        {
            this.SetItemInternal(index, keyFrame);
        }
#endif
    }
}