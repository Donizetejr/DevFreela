﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.Start
{
    public class DeleteCommand : IRequest<Unit>
    {
        public DeleteCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
