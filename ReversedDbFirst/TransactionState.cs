using System;
using System.Collections.Generic;

namespace ReversedDbFirst;

public partial class TransactionState
{
    public Guid OperationId { get; set; }

    public Guid TransactionId { get; set; }

    public int State { get; set; }

    public DateTime DateCreated { get; set; }
}
