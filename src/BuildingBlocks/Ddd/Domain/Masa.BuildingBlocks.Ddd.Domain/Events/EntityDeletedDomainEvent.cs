// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Ddd.Domain.Events
{
    public record class EntityDeletedDomainEvent<TEntity> : EntityChangedEvent<TEntity>
    {
        public EntityDeletedDomainEvent(TEntity entity) : base(entity)
        {
        }
    }
}
