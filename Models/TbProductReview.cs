﻿using System;
using System.Collections.Generic;

namespace ASP.NET_Core_MVC.Models;

public partial class TbProductReview
{
    public int ProductReviewId { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Detail { get; set; }

    public int? Star { get; set; }

    public int? ProductId { get; set; }

    public bool IsActive { get; set; }

    public virtual TbProduct? Product { get; set; }

    public string? Image { get; set; }
}
