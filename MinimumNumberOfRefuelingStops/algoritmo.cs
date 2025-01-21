using System;
using System.Collections.Generic;

public class Solution {
    public int MinRefuelStops(int target, int startFuel, int[][] stations) {
        List<int> melhoresOpcoes = new List<int>();
        
        int posicaoAtual = startFuel;      
        int numeroParadas = 0;            
        int postoAtual = 0;                

        while (posicaoAtual < target) { 
            while (postoAtual < stations.Length && stations[postoAtual][0] <= posicaoAtual) {
                melhoresOpcoes.Add(stations[postoAtual][1]);
                postoAtual++;
            }

            if (melhoresOpcoes.Count == 0) {
                return -1;  
            }

            int melhorOpcao = 0;
            int indiceMelhorOpcao = 0;

            for (int i = 0; i < melhoresOpcoes.Count; i++) {
                if (melhoresOpcoes[i] > melhorOpcao) {
                    melhorOpcao = melhoresOpcoes[i];
                    indiceMelhorOpcao = i;
                }
            }

            posicaoAtual += melhorOpcao;
            melhoresOpcoes.RemoveAt(indiceMelhorOpcao);
            numeroParadas++;
        }
        
        return numeroParadas;
    }
}