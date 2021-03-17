﻿using System;

namespace Restaurant.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}