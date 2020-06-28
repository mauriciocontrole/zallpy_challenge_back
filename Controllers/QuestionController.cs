using System.Collections.Generic;
using System.Threading.Tasks; // P/ trabalhar de forma assíncrona
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using zallpy_challenge_back.Models;
using zallpy_challenge_back.Data;
using System;

namespace zallpy_challenge_back.Controllers
{
    /*
        Como a gnt não mapeou nenhuma rota,
        ao final do Startup.cs, ele vai tentar
        se basear pelas rotas do controller.
        Então é interessante que utilizemos o
        Route()
    */
    [ApiController]
    [Route("questions")]
    public class QuestionController : ControllerBase
    {
        /*
            Tudo que eu colocar em Route("")
            ele vai concatenar com a Route de
            cima "v1/questions".
        */
        [HttpGet]
        [Route("")]
        //public async Task<ActionResult<List<Question>>> Get([FromServices] DataContext context)
        public async Task<ActionResult<List<Question>>> Get([FromServices] DataContext context)
        {
            Console.WriteLine("COMANDO GET!");

            /*
                Aqui a gnt vai buscar
                todas as questions.
            */
            var originalQuestions = await context.Questions.ToListAsync();            
            
            /*
            */
            List<Question> randomQuestions = new List<Question>();
            

            /*
                Aqui é feito um tratamento para que os
                elementos da lista sejam embaralhados
                e as perguntas saiam no front de forma
                aleatória
            */
            Random randNum = new Random();

            for (int i = 4; i >= 0; i--)
            {
                /*
                    Gera um número aleatório
                    que pode variar de 0 a i,
                    onde i é decrementado a
                    cada loop até chegar a 0.
                */
                int index = randNum.Next(i);
                
                //Console.WriteLine(index);

                /*
                    Utiliza o index (numero aleatorio)
                    para pegar um elemento na lista
                    original e passar para a lista random.
                */
                randomQuestions.Add(originalQuestions[index]);
                
                /*
                    Troca os Id's fazendo com que eles cheguem
                    no front de forma "ordenada" (de 1 a 5).

                    Depois eu percebi que não precisaria fazer
                    isso pq o front não utiliza esse Id.
                    
                    Mas resolvi deixar ai.
                */
                randomQuestions[randomQuestions.Count - 1].Id = randomQuestions.Count;

                /*
                    Remove o item da lista orinal pois ele já
                    foi recebido pela lista random.
                */
                originalQuestions.RemoveAt(index);
            }

            return randomQuestions;
        }







        /*
            No POST, vamos ter a mesma rota.
            Ele só chaveia pelo verbo.

            Este verbo não será utilizado nessa
            primeira versão do projeto.

            Talvez em uma segunda versão ele
            seja aproveitado para trazer a parte
            de lógica (cálculo da %, ...) que ficou
            no front.
        */
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Question>> Post(
            [FromServices] DataContext context, // Aqui eu recebo do serviço DataContext p/ ser injetado.
            [FromBody] Question model) // E do corpo da requisição, eu recebo a minha categoria.
        {
            /*
                Aqui eu to validando a
                categoria (se ela tem
                todos aqueles requisitos:
                Required, MaxLength e
                MinLength) de Category.cs
            */
            if (ModelState.IsValid)
            {
                /*
                    Como o DataContext é a representação
                    do banco de dados em memória, ele não
                    persistiu nada no banco ainda.
                */
                context.Questions.Add(model);
                await context.SaveChangesAsync();
                return model;
            }

            // Se der algum erro
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}