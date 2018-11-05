/*
 * Copyright (c) 2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using System;
using System.Collections.Generic;
using Piranha.Data;

namespace Piranha.Manager.Models
{
    public class MediaListModel
    {
        public Guid? CurrentFolder { get; set; }
        public IEnumerable<Media> Items { get; set; } = new List<Media>();
    }
}