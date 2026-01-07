using ECommerceApp.DTOs;
using ECommerceApp.DTOs.CustomerDTOs;
using ECommerceApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly CustomerService _customerService;

    public CustomersController(CustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<ApiResponse<CustomerResponseDTO>>> RegisterCustomer([FromBody] CustomerRegistrationDTO customerDto)
    {
        var response = await _customerService.RegisterAsync(customerDto);

        if (response.StatusCode != 200)
            return StatusCode((int)response.StatusCode, response);

        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<ActionResult<ApiResponse<LoginResponseDTO>>> Login([FromBody] LoginDTO loginDto)
    {
        return null;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<CustomerResponseDTO>>> GetCustomerById(int id)
    {
        var response = await _customerService.GetCustomerByIdAsync(id);

        if (response.StatusCode != 200)
            return StatusCode((int)response.StatusCode, response);

        return Ok(response);
    }

    [HttpPut("update")]
    public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateCustomer([FromBody] CustomerUpdateDTO customerDto)
    {
        var response = await _customerService.UpdateCustomerAsync(customerDto);

        if (response.StatusCode != 200)
        {
            return StatusCode((int)response.StatusCode, response);
        }

        return Ok(response);
    }

    [HttpDelete("delete/{id}")]
    public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteCustomer(int id)
    {
        var response = await _customerService.DeleteCustomerAsync(id);
        if (response.StatusCode != 200)
        {
            return StatusCode((int)response.StatusCode, response);
        }
        return Ok(response);
    }
    
    [HttpPost("changepassword")]
    public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> ChangePassword([FromBody] ChangePasswordDTO changePasswordDto)
    {
        var response = await _customerService.ChangePasswordAsync(changePasswordDto);
        if (response.StatusCode != 200)
        {
            return StatusCode((int)response.StatusCode, response);
        }
        return Ok(response);
    }
}