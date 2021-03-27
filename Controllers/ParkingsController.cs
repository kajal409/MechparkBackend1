﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.ParkingHistories;
using WebApi.Models.Parkings;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingsController : ControllerBase
    {
        private IParkingService _parkingService;
        private IMapper _mapper;

        public ParkingsController(
            IParkingService parkingService,
            IMapper mapper)
        {
            _parkingService = parkingService;
            _mapper = mapper;
        }

        [Authorize(Roles = "User")]
        [HttpPost("book")]
        public IActionResult Book([FromBody] BookParkingModel model)
        {
            var parking = _mapper.Map<Parking>(model);
            var context = HttpContext.User.Identity;
            int id = int.Parse(context.Name);

            try
            {
                _parkingService.Book(parking, id);
                return Ok(new { message = "✓ Parking Booked" });
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [Authorize(Roles = "User")]
        [HttpPost("checkin")]
        public IActionResult CheckIn()
        {
            var context = HttpContext.User.Identity;
            int id = int.Parse(context.Name);

            try
            {
                _parkingService.CheckIn(id);
                return Ok(new { message = "✓ Parking CheckIn" });
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [Authorize(Roles = "User")]
        [HttpPost("checkout")]
        public IActionResult CheckOut()
        {
            var context = HttpContext.User.Identity;
            int id = int.Parse(context.Name);

            try
            {
                _parkingService.CheckOut(id);
                return Ok(new { message = "✓ Parking CheckOut" });
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [Authorize(Roles = "AllocationManager")]
        [HttpPost("system/checkin")]
        public IActionResult SystemCheckIn([FromBody] BookParkingAllocationModel model)
        {
            var context = HttpContext.User.Identity;
            int id = int.Parse(context.Name);

            var userParking = _mapper.Map<Parking>(model);

            try
            {
                _parkingService.CheckIn(userParking.UserId);
                return Ok(new { message = "✓ Parking CheckIn" });
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [Authorize(Roles = "AllocationManager")]
        [HttpPost("system/checkout")]
        public IActionResult SystemCheckOut([FromBody] BookParkingAllocationModel model)
        {
            var context = HttpContext.User.Identity;
            int id = int.Parse(context.Name);
            var userParking = _mapper.Map<Parking>(model);


            try
            {
                _parkingService.CheckOut(userParking.UserId);
                return Ok(new { message = "✓ Parking CheckOut" });
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [Authorize(Roles = "Admin, User")]
        [HttpGet("byuser/{id}")]
        public IActionResult GetParkingByUser(int id)
        {
            var parking = _parkingService.GetByUserId(id);
            var model = _mapper.Map<ParkingResponse>(parking);
            return Ok(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("active")]
        public IActionResult GetActiveParkings()
        {
            var parkings = _parkingService.GetActiveParkings();
            var model = _mapper.Map<IList<Parking>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles = "ParkingManager")]
        [HttpGet("garage/{id}")]
        public IActionResult GetParkingsByGarage(int id)
        {
            var parkings = _parkingService.GetParkingsByGarage(id);
            var model = _mapper.Map<IList<Parking>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles = "ParkingManager")]
        [HttpGet("history/garage/{id}")]
        public IActionResult GetParkingHistoryByGarage(int id)
        {
            var parkings = _parkingService.GetParkingHistoryByGarage(id);
            var model = _mapper.Map<IList<ParkingHistory>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles = "AllocationManager")]
        [HttpGet("space/{id}")]
        public IActionResult GetParkingsBySpace(int id)
        {
            var parkings = _parkingService.GetParkingsBySpace(id);
            var model = _mapper.Map<IList<Parking>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles = "AllocationManager")]
        [HttpGet("history/space/{id}")]
        public IActionResult GetParkingHistoryBySpace(int id)
        {
            var parkings = _parkingService.GetParkingHistoryBySpace(id);
            var model = _mapper.Map<IList<ParkingHistory>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles ="Admin")]
        [HttpGet("")]
        public IActionResult GetAllParkings()
        {
            var parkings = _parkingService.GetAllParkings();
            var model = _mapper.Map<IList<Parking>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("history/")]
        public IActionResult GetAllParkingHistory()
        {
            var parkingHistory = _parkingService.GetAllParkingHistory();
            var model = _mapper.Map<IList<ParkingHistory>>(parkingHistory);
            return Ok(model);
        }

        [Authorize(Roles = "AllocationManager")]
        [HttpGet("allocationmanager/{id}")]
        public IActionResult GetParkingsByAllocationManager(int id)
        {
            var parkings = _parkingService.GetParkingsByAllocationManager(id);
            var model = _mapper.Map<IList<Parking>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles = "AllocationManager")]
        [HttpGet("history/allocationmanager/{id}")]
        public IActionResult GetParkingHistoryByAllocationManager(int id)
        {
            var parkings = _parkingService.GetParkingHistoryByAllocationManager(id);
            var model = _mapper.Map<IList<ParkingHistory>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("inactive")]
        public IActionResult GetInActiveParkings()
        {
            var parkings = _parkingService.GetInactiveParkings();
            var model = _mapper.Map<IList<Parking>>(parkings);
            return Ok(model);
        }

        [Authorize(Roles = "User")]
        [HttpGet("user-history")]
        public IActionResult GetUserParkingHistories()
        {
            var context = HttpContext.User.Identity;
            int id = int.Parse(context.Name);
            var parkingHistories = _parkingService.GetUserParkingHistories(id);
            var model = _mapper.Map<IList<ReceiptModel>>(parkingHistories);
            return Ok(model);
        }

        [Authorize(Roles = "User")]
        [HttpGet("receipt")]
        public IActionResult GetReceipt()
        {
            var context = HttpContext.User.Identity;
            int id = int.Parse(context.Name);
            var parkingHistory = _parkingService.GetReceipt(id);
            var model = _mapper.Map<ReceiptModel>(parkingHistory);
            return Ok(model);
        }
    }
}
