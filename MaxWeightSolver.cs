public class MaxWeightSolver{
    /*Find the max that can be made from 
    an array of input profits.  We cannot pick
    consecutive inputs. 
    */
    public int SolveWithoutRecursion(int[] inputArray){

        int[] tempArray = new int[inputArray.Length+1];
        if (inputArray.Length == 0){
            return 0;
        }

        if (inputArray.Length == 1){
            return inputArray[1];
        }
        int j=0;
        for (int i = 2; i <= inputArray.Length; i++)
        {
            tempArray[i] = Math.Max(inputArray[i-1],inputArray[i-2]+inputArray[j]);
            j++;
        }
        return tempArray[inputArray.Length];
    }
}