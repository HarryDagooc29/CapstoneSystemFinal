// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using HarryMidterm.Models; // Replace with your model namespace

// [Route("api/[controller]")]
// [ApiController]
// public class FetchController : ControllerBase
// {
//     private readonly YourDbContext _context; // Replace with your DbContext class

//     public FetchController(YourDbContext context)
//     {
//         _context = context;
//     }

//     [HttpGet("fetchAndInsertData")]
//     public IActionResult FetchAndInsertData()
//     {
//         try
//         {
//             // Step 1: Retrieve data from the source table
//             var sourceData = _context.SourceTable.ToList(); // Use appropriate query to fetch data

//             // Step 2 & 3: Transform data (if needed) and insert into the destination table
//             foreach (var sourceRecord in sourceData)
//             {
//                 var destinationRecord = new DestinationTable
//                 {
//                     // Map properties from sourceRecord to destinationRecord if needed
//                     // Example: Property1 = sourceRecord.Property1,
//                 };

//                 _context.DestinationTable.Add(destinationRecord);
//             }

//             // Step 4: Save changes to the destination table
//             _context.SaveChanges();

//             return Ok("Data fetched and inserted successfully.");
//         }
//         catch (Exception ex)
//         {
//             return BadRequest($"An error occurred: {ex.Message}");
//         }
//     }
// }
