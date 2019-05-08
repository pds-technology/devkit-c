using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Packaging;
namespace DevkitTest
{
    /// <summary>
    /// the ECPCore Property store the core property from epc pacakage.
    /// </summary>
    class EPCCoreProperty : PackageProperties
    {
        String category;
        String contentStatus;
        String contenttype;
        String language;
        String lastModifiedBy;
        DateTime? lastprinted;
        DateTime? modified;
        String revision;
        String subject;
        String keywords;
        String version;
        String title;
        String description;
        DateTime? created;
        String creator;
        String identifier;

        public override string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public override string ContentStatus
        {
            get
            {
                return contentStatus;
            }
            set
            {
                contentStatus = value;
            }
        }

        public override string ContentType
        {
            get
            {
                return contenttype;
            }
            set
            {
                contenttype = value;
            }
        }

        public override string Language
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
            }
        }

        public override string LastModifiedBy
        {
            get
            {
                return lastModifiedBy;
            }
            set
            {
                lastModifiedBy = value;
            }
        }

        public override DateTime? LastPrinted
        {
            get
            {
                return lastprinted;
            }
            set
            {
                lastprinted = value;
            }
        }

        public override DateTime? Modified
        {
            get
            {
                return modified;
            }
            set
            {
                modified = value;
            }
        }
        public override string Revision
        {
            get
            {
                return revision;
            }
            set
            {
                revision = value;
            }
        }

        public override string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public override DateTime? Created
        {
            get
            {
                return created;
            }
            set
            {
                created = value;
            }
        }

        public override string Creator
        {
            get
            {
                return creator;
            }
            set
            {
                creator = value;
            }
        }

        public override string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public override string Identifier
        {
            get
            {
                return identifier; 
            }
            set
            {
                identifier = value;
            }
        }

        public override string Keywords
        {
            get
            {
                return keywords;
            }
            set
            {
                keywords = value;
            }
        }

        public override string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public override string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }
    }
}
