/*
 * Copyright (c) 2016-2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

namespace Piranha.Manager.Models
{
    /// <summary>
    /// Base class for page regions.
    /// </summary>
    public abstract class ContentEditRegion
    {
        /// <summary>
        /// Gets/sets the region id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets/sets the region title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets/sets the CLR type.
        /// </summary>
        public string CLRType { get; set; }

        /// <summary>
        /// Gets/sets the optional regions description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Adds a field set to the region.
        /// </summary>
        /// <param name="fieldSet">The field set</param>
        public abstract void Add(ContentEditFieldSet fieldSet);
    }    
}