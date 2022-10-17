﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ProductToAddInFridgeWNDTO
    {
		[Required(ErrorMessage = "ProductId is required")]
		public Guid ProductId { get; set; }

		public string Name { get; set; }

		public bool Changed { get; set; }

		[Range(0, 999999, ErrorMessage = "Quantity must be equal or more than 0")]
		public int Quantity { get; set; }
	}
}
