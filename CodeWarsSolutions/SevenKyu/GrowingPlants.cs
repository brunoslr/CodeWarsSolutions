/* URL: https://www.codewars.com/kata/simple-fun-number-74-growing-plant/csharp
Each day a plant is growing by upSpeed meters. Each night that plant's height decreases by downSpeed meters due to the lack of sun heat. Initially, plant is 0 meters tall. We plant the seed at the beginning of a day. We want to know when the height of the plant will reach a certain level.
Example
For upSpeed = 100, downSpeed = 10 and desiredHeight = 910, the output should be 10. 
*/

namespace CodeWarsSolutions.SevenKyu
{
    public class GrowingPlants
    {
        public int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            var currentHeight = 0;
            var currentDay = 0;
            while (currentHeight < desiredHeight)
            {
                currentDay++;
                if ((currentHeight + upSpeed) >= desiredHeight)
                    return currentDay;

                currentHeight += (upSpeed - downSpeed);
            }
            return currentDay;   
        }
    }
}
