public class Solution {
    public int Candy(int[] ratings) {
        int numeroCriancas = ratings.Length;
        
        int[] docesPorCrianca = new int[numeroCriancas];
        
        for (int i = 0; i < numeroCriancas; i++) {
            docesPorCrianca[i] = 1;
        }

        for (int i = 1; i < numeroCriancas; i++) {
            if (ratings[i] > ratings[i - 1]) {
                docesPorCrianca[i] = docesPorCrianca[i - 1] + 1;
            }
        }

        for (int i = numeroCriancas - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1]) {
                int docesNecessarios = docesPorCrianca[i + 1] + 1;
                docesPorCrianca[i] = Math.Max(docesPorCrianca[i], docesNecessarios);
            }
        }
        
        int totalDoces = 0;
        for (int i = 0; i < numeroCriancas; i++) {
            totalDoces += docesPorCrianca[i];
        } 
        return totalDoces;
    }
}