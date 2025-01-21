public class Solution {
    public int Jump(int[] nums) {
        int numeroSaltos = 0;         
        int alcanceAtual = 0;        
        int alcanceMaximo = 0;        

        for (int posicao = 0; posicao < nums.Length - 1; posicao++) {

            int alcancePossivel = posicao + nums[posicao];
            alcanceMaximo = Math.Max(alcanceMaximo, alcancePossivel);

            if (posicao == alcanceAtual) {
                numeroSaltos++;

                alcanceAtual = alcanceMaximo;

                if (alcanceAtual >= nums.Length - 1) {
                    break;
                }
            }
        }
        return numeroSaltos;
    }
}