using System.Collections.Generic;

namespace Variant_1.ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        private string[] isOddList = new[] {"Нечетное", "Четное", "Неизвестно"};
        private string[] multipleByThreeList = new[] {"Нечетное трём", "Четное трём", "Неизвестно"};
        private const string DEFAULT_VALUE_INPUT = "Введите число";
        private const string DEFAULT_VALUE_ISODD = "Неизвестно";
        private const string DEFAULT_VALUE_SUMM = "Сумма чисел: ";
        private const string DEFAULT_VALUE_MULTIP = "Произведение чисел: ";
        private const string DEFAULT_VALUE_MULTIPLE_BY_THREE = "Неизвестно";
        private bool isOdd(int number)
        {
            return isMultipleBy(2, number);
        }

        private bool isMultipleBy(int by, int number)
        {
            return number % by == 0;
        }

        private string getIsOddString(int number)
        {
            if (isOdd(number))
            {
                return isOddList[1];
            }
            else
            {
                return isOddList[0];
            }
        }

        private int getNumbersSumm(int numbers)
        {
            int sum = 0;
            string rawNumbers = numbers.ToString();
            foreach (var rawNumber in rawNumbers)
            {
                KeyValuePair<bool, int> parsed = parseStringToInt(rawNumber.ToString());
                if (parsed.Key)
                {
                    sum += parsed.Value;
                }
            }
            return sum;
        }

        private int getNumberMultip(int numbers)
        {
            int multip = 1;
            string rawNumbers = numbers.ToString();
            foreach (var rawNumber in rawNumbers)
            {
                KeyValuePair<bool, int> parsed = parseStringToInt(rawNumber.ToString());
                if (parsed.Key)
                {
                    multip *= parsed.Value;
                }
            }
            return multip;   
        }

        private string getIsMultipleByThreeString(int number)
        {
            if (isMultipleBy(3, number))
            {
                return multipleByThreeList[1];
            }
            else
            {
                return multipleByThreeList[0];

            }
        }

        private KeyValuePair<bool, int> parseStringToInt(string rawNumber)
        {
            int number;
            if (int.TryParse(rawNumber, out number))
            {
                return new KeyValuePair<bool, int>(true, number);
            }
            else
            {
                return new KeyValuePair<bool, int>(false, number);
            }
        }

        private void calcIsOdd(string rawNumber)
        {
            KeyValuePair<bool, int> parsed = parseStringToInt(rawNumber);
            if (parsed.Key)
            {
                isOddValue = getIsOddString(parsed.Value);
            }
            else
            {
                isOddValue = isOddList[2];
            }
        }

        private void calcSumm(string rawNumber)
        {
            KeyValuePair<bool, int> parsed = parseStringToInt(rawNumber);
            if (parsed.Key)
            {
                summValue = DEFAULT_VALUE_SUMM+getNumbersSumm(parsed.Value);
            }
            else
            {
                summValue = DEFAULT_VALUE_SUMM;
            }
        }

        private void calcMultip(string rawNumber)
        {
            KeyValuePair<bool, int> parsed = parseStringToInt(rawNumber);
            if (parsed.Key)
            {
                multipValue = DEFAULT_VALUE_MULTIP+getNumberMultip(parsed.Value);
            }
            else
            {
                multipValue = DEFAULT_VALUE_MULTIP;
            }
        }

        private void calcMultipleByThree(string rawNumber)
        {
            KeyValuePair<bool, int> parsed = parseStringToInt(rawNumber);
            if (parsed.Key)
            {
                multipleByThreeValue = getIsMultipleByThreeString(parsed.Value);
            }
            else
            {
                multipleByThreeValue = DEFAULT_VALUE_MULTIPLE_BY_THREE;
            }
        }

        private string _isOddValue = DEFAULT_VALUE_ISODD;
        public string isOddValue
        {
            get
            {
                return _isOddValue;
            }
            set
            {
                _isOddValue = value;
                OnPropertyChanged();
            }
        }

        private string _rawInputValue = DEFAULT_VALUE_INPUT;

        public string rawInputValue
        {
            get { return _rawInputValue; }
            set
            {
                _rawInputValue = value;
                calcIsOdd(value);
                calcSumm(value);
                calcMultip(value);
                calcMultipleByThree(value);
                OnPropertyChanged();
            }
        }

        private string _summValue = DEFAULT_VALUE_SUMM;

        public string summValue
        {
            get
            {
                return _summValue;
            }
            set
            {
                _summValue = value;
                OnPropertyChanged(nameof(summValue));
            }
        }

        private string _multipValue = DEFAULT_VALUE_MULTIP;

        public string multipValue
        {
            get
            {
                return _multipValue;
            }
            set
            {
                _multipValue = value;
                OnPropertyChanged(nameof(multipValue));
            }
        }

        private string _multipleByThreeValue = DEFAULT_VALUE_MULTIPLE_BY_THREE;

        public string multipleByThreeValue
        {
            get
            {
                return _multipleByThreeValue;
            }
            set
            {
                _multipleByThreeValue = value;
                OnPropertyChanged(nameof(multipleByThreeValue));
            }
        }

    }
}