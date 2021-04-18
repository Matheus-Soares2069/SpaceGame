using GameSpaceAdventure.Classes;
using System;

namespace GameSpaceAdventure
{
    class TestaGame
    {
        static void Main(string[] args)
        {
           
            NaveAtaque naveAtaqueBobNelson = new NaveAtaque();
            Posicao posicaoInicialJogo = new Posicao();
            posicaoInicialJogo.Posicao_x = 0;
            posicaoInicialJogo.Posicao_y = 0;
            naveAtaqueBobNelson.Nome = "BobNave";
            naveAtaqueBobNelson.Velocidade = 40;
            naveAtaqueBobNelson.Energia = 100;
            naveAtaqueBobNelson.Combustivel = 50;
            naveAtaqueBobNelson.Posicao = posicaoInicialJogo;
            naveAtaqueBobNelson.PotenciaTiro = 10;
            naveAtaqueBobNelson.VelocidadeTiro = 60;

            Posicao posicaoInicialNavePirata = new Posicao();
            posicaoInicialNavePirata.Posicao_x = 20;
            posicaoInicialNavePirata.Posicao_y = 0;
            NaveAtaque navePirataUm = new NaveAtaque("Pirata Nível1", 20, 80, 50, posicaoInicialNavePirata, 3, 20);
            NaveAtaque navePirataDois = new NaveAtaque();
            navePirataDois.Nome = "Pirata Nível2";
            navePirataDois.Velocidade = 30;
            navePirataDois.Energia = 80;
            navePirataDois.Combustivel = 60;
            navePirataDois.Posicao = posicaoInicialNavePirata;
            navePirataDois.PotenciaTiro = 5;
            navePirataDois.VelocidadeTiro = 40;

            Posicao posicaoNaveTranporteBobNelson = new Posicao();
            NaveTransporte naveTransporteBobNelson = new NaveTransporte("Touro Azul", 20, 120, 70, posicaoInicialJogo, 10);

            Posicao posicaoInicialAsteroides = new Posicao(0, 0);
            Asteroide asteroideAlfa = new Asteroide(20, posicaoInicialAsteroides);
            naveAtaqueBobNelson.Movimentar();
            asteroideAlfa.Movimentar();
            navePirataUm.Movimentar();
            navePirataUm.Atirar();
            naveAtaqueBobNelson.DanoLeve();
            naveAtaqueBobNelson.Atirar();
            navePirataUm.DanoGrave();
        }
    }
}
