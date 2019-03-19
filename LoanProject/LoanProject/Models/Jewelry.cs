using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace LoanProject.Models
{
    public class Jewelry : ObservableObject
    {
        private string _jewelryId;
        private JewelryType _jewelryType;
        private JewelryQuality _jewelryQuality;
        private double _jewelryWeight;
        private double _jewelryDiscount;
        private string _jewelryOtherDetails;
        private double _jewelryValue;

        public string JewelryID
        {
            get { return _jewelryId; }
            set
            {
                _jewelryId = value;
                RaisePropertyChanged(nameof(JewelryID));
            }
        }

        public JewelryType JewelryType
        {
            get { return _jewelryType; }
            set
            {
                _jewelryType = value;
                RaisePropertyChanged(nameof(JewelryType));
            }
        }

        public JewelryQuality JewelryQuality
        {
            get { return _jewelryQuality; }
            set
            {
                _jewelryQuality = value;
                RaisePropertyChanged(nameof(JewelryQuality));
            }
        }

        public double JewelryWeight
        {
            get { return _jewelryWeight; }
            set
            {
                _jewelryWeight = value;
                RaisePropertyChanged(nameof(JewelryWeight));
            }
        }

        public double JewelryDiscount
        {
            get { return _jewelryDiscount; }
            set
            {
                _jewelryDiscount = value;
                RaisePropertyChanged(nameof(JewelryDiscount));
            }
        }

        public string JewelryOtherDetails
        {
            get { return _jewelryOtherDetails; }
            set
            {
                _jewelryOtherDetails = value;
                RaisePropertyChanged(nameof(JewelryOtherDetails));
            }
        }

        public double JewelryValue
        {
            get { return _jewelryValue; }
            set
            {
                _jewelryValue = value;
                RaisePropertyChanged(nameof(JewelryValue));
            }
        }

        public string[] JewelryTypes => Enum.GetNames(typeof(JewelryType));
        public string[] JewelryQualities => Enum.GetNames(typeof(JewelryQuality));
    }

    public enum JewelryType
    {
        Rings,
        Necklaces,
        Bracelets,
        Earrings
    }

    public enum JewelryQuality
    {
        TenKarats,
        EighteenKarats,
        TwentyOneKarats
    }
}
