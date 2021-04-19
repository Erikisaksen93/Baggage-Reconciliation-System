using System;
using System.Collections.Generic;
using System.Text;

namespace Baggage_Reconciliation_System
{
    class Bag
    {
        private float _weight;
        private string _bagId;
        private Booking _booking;
        private Random rnd = new Random();

        public Bag(float weight, string bagId, Booking booking = null)
        {
            _weight = weight;
            _bagId = bagId;
            _booking = booking;
        }

        public string GetBagInfo()
        {
            return $"1 pcs {_weight}kg ({RandomBagId()})";
        }

        private string GenerateRandomTagIdNumber()
        {
            var tagIdNumber = rnd.Next(1, 9);
            return tagIdNumber.ToString();

        }

        private string GenerateRandomTagIdLetterCombination()
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";
            var tagIdCharacters = letters[rnd.Next(0, 25)];
            return tagIdCharacters.ToString().ToUpper();
        }

        private string RandomBagId()
        {
            return GenerateRandomTagIdLetterCombination() +
                   GenerateRandomTagIdLetterCombination() +
                   GenerateRandomTagIdNumber() +
                   GenerateRandomTagIdNumber() +
                   GenerateRandomTagIdNumber() +
                   GenerateRandomTagIdNumber() +
                   GenerateRandomTagIdNumber();
        }
        

    }

    
}
