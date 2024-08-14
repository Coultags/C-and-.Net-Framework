using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne._2
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        { //Created value for each face card.
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1,
        };
        private static int[] GetAllPossibleHandValue(List<Card> Hand)
        { //Checks the total sum of the player/dealer hands
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        public static bool CheckforBlackJack(List<Card> Hand)
        {   //Checks for blackjack in either hand
            int[] possibleValues = GetAllPossibleHandValue(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        { //Checks if either player or dealer busts on their hand
            int value = GetAllPossibleHandValue(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        { //Creates a rule for the dealer to stay if hand is more 16 but less then 22
            int[] possibleValues = GetAllPossibleHandValue(Hand);
            foreach (int value in possibleValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHand(List<Card> PlayerHand, List<Card> DealerHand)
        { //Checks both hands and compares who has the higher hand.
            int[] playerResults = GetAllPossibleHandValue(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValue(DealerHand);

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
