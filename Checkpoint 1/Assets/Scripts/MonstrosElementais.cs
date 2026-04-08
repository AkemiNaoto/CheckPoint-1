// Nome: Akemi Vicente da Silva
// RM: 573664

using UnityEngine;

public class MonstrosElementais : MonoBehaviour
{
    
    [SerializeField] private string MonstroPlayer;
    private string MonstroCPU;
    private int PontosPlayer, PontosCPU, EscolhaCPU;
    private bool EscolhaFeita;

    void Start()
    {

        PontosPlayer = 0;
        PontosCPU = 0;
        EscolhaFeita = false;

        print("O combate iniciou escolha entre os monstros de Água, Fogo ou Pedra");

    }

    
    void Update()
    {
            
        if(Input.anyKeyDown)
        {

            if (MonstroPlayer == "Fogo" || MonstroPlayer == "Água" || MonstroPlayer == "Pedra")
            {
            
            EscolhaFeita = true;

            }

            else
            {
            
            EscolhaFeita = false;
            print("Você escolheu um monstro que não existe, por favor escolha entre os monstros de Fogo, Água e Pedra");

            }

            if(EscolhaFeita == true)
            {
                
                if(PontosPlayer < 3 && PontosCPU < 3)
                {
                    
                    EscolhaCPU = Random.Range(1, 4);

                    if (EscolhaCPU == 1)
                    {
                    
                        MonstroCPU = "Fogo";

                    }

                    else if(EscolhaCPU == 2)
                    {
                        
                        MonstroCPU = "Água";

                    }

                    else if(EscolhaCPU == 3)
                    {
                        
                        MonstroCPU = "Pedra";

                    }

                    if(MonstroPlayer == MonstroCPU)
                    {
                        
                        print("Você escolheu o monstro de " + MonstroPlayer + " e a CPU escolheu o monstro de " + MonstroCPU + " devido a serem iguais deu empate." );
                        print("O placar está atualmente com " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                    }

                    else if(MonstroPlayer == "Fogo" && MonstroCPU == "Água")
                    {
                        
                        PontosCPU += 1;
                        print("Você escolheu o monstro de " + MonstroPlayer + " e a CPU escolheu o monstro de " + MonstroCPU + " devido a isso você perdeu." );
                        print("O placar está atualmente com " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                    }

                    else if(MonstroPlayer == "Fogo" && MonstroCPU == "Pedra")
                    {
                        
                        PontosPlayer += 1;
                        print("Você escolheu o monstro de " + MonstroPlayer + " e a CPU escolheu o monstro de " + MonstroCPU + " devido a isso você ganhou." );
                        print("O placar está atualmente com " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                    }

                    else if(MonstroPlayer == "Fogo" && MonstroCPU == "Fogo")
                    {
                        
                        PontosPlayer += 1;
                        print("Você escolheu o monstro de " + MonstroPlayer + " e a CPU escolheu o monstro de " + MonstroCPU + " devido a isso você ganhou." );
                        print("O placar está atualmente com " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                    }

                    else if(MonstroPlayer == "Água" && MonstroCPU == "Pedra")
                    {
                        
                        PontosCPU += 1;
                        print("Você escolheu o monstro de " + MonstroPlayer + " e a CPU escolheu o monstro de " + MonstroCPU + " devido a isso a você perdeu." );
                        print("O placar está atualmente com " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                    }

                    else if(MonstroPlayer == "Pedra" && MonstroCPU == "Fogo")
                    {
                        
                        PontosCPU += 1;
                        print("Você escolheu o monstro de " + MonstroPlayer + " e a CPU escolheu o monstro de " + MonstroCPU + " devido a isso você perdeu." );
                        print("O placar está atualmente com " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                    }

                    else if(MonstroPlayer == "Pedra" && MonstroCPU == "Água")
                    {
                        
                        PontosPlayer += 1;
                        print("Você escolheu o monstro de " + MonstroPlayer + " e a CPU escolheu o monstro de " + MonstroCPU + " devido a isso você ganhou." );
                        print("O placar está atualmente com " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                    }

                }

                else if(PontosPlayer == 3)
                {
                    
                    print("Você ganhou, a pontuação final foi " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                }

                else if(PontosCPU == 3)
                {
                    
                    print("Você perdeu, a pontuação final foi " + PontosPlayer + " pontos para você e " + PontosCPU + " pontos para a CPU.");

                }
            }    

        }

    }
}
