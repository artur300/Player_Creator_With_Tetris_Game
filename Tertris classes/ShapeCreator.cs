using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Game.Tertris_classes
{
    static class ShapeCreator
    {
        private static ClassShape[] shapeARR;

        static ShapeCreator()
        {
            shapeARR = new ClassShape[]
            {
                new ClassShape
                {
                    id="yellow",Width=2,Height=2,Dots=new int[,]
                    {
                        {1,1},
                        {1,1}
                    }
                },

                new ClassShape
                {
                    id="cyan",Width=1,Height=4,Dots=new int[,]
                    {
                        {1},
                        {1},
                        {1},
                        {1}
                    }
                },

                new ClassShape
                {
                    id="magenta",Width=3,Height=2,Dots=new int[,]
                    {
                         {0,1,0},
                         {1,1,1}
                    }
                },

                new ClassShape
                {
                    id="blue",Width=3,Height=2,Dots=new int[,]
                    {
                         {1,0,0},
                         {1,1,1}
                    }
                },

                new ClassShape
                {
                    id="orange",Width=3,Height=2,Dots=new int[,]
                    {
                         {0,0,1},
                         {1,1,1}
                    }
                },

                new ClassShape
                {
                    id="red",Width=3,Height=2,Dots=new int[,]
                    {
                         {0,1,1},
                         {1,1,0}
                    }
                },

                new ClassShape
                {
                    id="green",Width=3,Height=2,Dots=new int[,]
                    {
                         {1,1,0},
                         {0,1,1}
                    }
                },


            };

        }

        public static ClassShape get_random_shape()
        {

            var shape = shapeARR[new Random().Next(shapeARR.Length)];
            return shape;
        }
    }
}

