using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();

        Video video1 = new Video("Cómo Programar en C#", "Juan Pérez", 180);
        video1.AddComment(new Comment("Alice", "Excelente tutorial, muy claro."));
        video1.AddComment(new Comment("Bob", "Me ayudó mucho, gracias!"));
        video1.AddComment(new Comment("Carlos", "Buen contenido, pero la explicación fue un poco rápida."));
        videos.Add(video1);

        Video video2 = new Video("Top 5 Lenguajes de Programación", "Ana García", 220);
        video2.AddComment(new Comment("David", "Interesante lista, aunque falta Python."));
        video2.AddComment(new Comment("Eva", "Yo pondría más lenguajes como Go o Rust."));
        video2.AddComment(new Comment("Frank", "Buen video, muy completo."));
        videos.Add(video2);


        Video video3 = new Video("Desarrollo Web con React", "Pedro López", 240);
        video3.AddComment(new Comment("Sofia", "React es genial, pero ¿qué pasa con Vue?"));
        video3.AddComment(new Comment("Luis", "Me gustaría ver un tutorial más largo."));
        video3.AddComment(new Comment("Marta", "Me encanta React, muchas gracias por compartir esto."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Título: {video.GetTitle()}");
            Console.WriteLine($"Autor: {video.GetAuthor()}");
            Console.WriteLine($"Duración: {video.GetLength()} segundos");
            Console.WriteLine($"Número de Comentarios: {video.GetNumberOfComments()}");
            Console.WriteLine("Comentarios:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}