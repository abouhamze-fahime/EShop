using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions;

/// <summary>
///  marker interface for domain events
/// </summary>
public sealed record UserCreatedDomainEvent(Guid userId) : IDomainEvent;