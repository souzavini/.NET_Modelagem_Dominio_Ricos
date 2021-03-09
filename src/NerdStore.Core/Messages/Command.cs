using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Messages
{
    public class Command : Message, IRequest<bool>
    {
        public DateTime TimeStamp { get; private set; }

        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public virtual bool Ehvalido()
        {
            throw new NotImplementedException();
        }
    }
}
