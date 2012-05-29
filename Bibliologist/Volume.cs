using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliologist
{
    public class Volume
    {
        public enum VolumeFormat
        {
            Hardcover,
            MassMarketPaperback,
            TradePaperback,
            Textbook,
            eBook,
            eBookDRM,
            Audiobook
        }

        public enum VolumeLocation
        {
            InCollection,
            OnLoan,
            OnWishlist
        }

        public enum VolumeStatus
        {
            Unread,
            InProgress,
            Read,
            Abandoned,
            Reference
        }

        public string[] ISBN { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string[] Authors { get; set; }
        public string[] Editors { get; set; }
        public string[] Translators { get; set; }
        public decimal Rating { get; set; }
        public string Comments { get; set; }
        public VolumeFormat Format { get; set; }
        public string Publisher { get; set; }
        public string PublishedYear { get; set; }
        public string[] Genres { get; set; }
        public string Synopsis { get; set; }
        public DateTime LastUpdate { get; set; }
        public VolumeLocation Location { get; set; }
        public VolumeStatus Status { get; set; }

    }
}
