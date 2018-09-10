using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VisaConsumerTransactionControlsAPI.Contracts;
using VisaConsumerTransactionControlsAPI.Models;
using VisaConsumerTransactionControlsAPI.Models.Request;

namespace VisaConsumerTransactionControlsAPI.Controllers
{
    [Route("api/[controller]")]
    public class CardConfigurationsController : Controller
    {
        private readonly ICardManager _cardManager;

        public CardConfigurationsController(ICardManager cardManager)
        {
            _cardManager = cardManager;
        }

        /// <summary>
        /// Register Card
        /// </summary>
        /// <param name="id"></param>
        /// <param name="registerRequest"></param>
        /// <returns></returns>
        [HttpPost("{id}/register")]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        public async Task<IActionResult> Post(string id, [FromBody] RegisterRequest registerRequest)
        {
            if (registerRequest == null)
            {
                return BadRequest();
            }

            var response = await _cardManager.RegisterAndActivateCard(new ActivationRequest
            {
                Id = id,
                Request = registerRequest
            });

            if (response == null)
            {
                return NotFound();
            }

            return Created(new Uri("api/cardconfigurations/register"), response);
        }

        /// <summary>
        /// Get Card Configurations
        /// </summary>
        /// <param name="id">Account number</param>
        /// <returns>CardConfigurationResponse object</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var config = await _cardManager.GetCardConfigurations(id);

            if (config == null)
            {
                return NotFound();
            }

            return Ok(config);
        }

        /// <summary>
        /// Create Configuration
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cardConfigurationFilter"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        public async Task<IActionResult> Post(string id, [FromBody] CardConfigurationFilter cardConfigurationFilter)
        {
            if (cardConfigurationFilter == null)
            {
                return BadRequest();
            }

            var response = await _cardManager.CreateCardConfiguration(cardConfigurationFilter);

            return Created(new Uri("api/cardconfigurations/"), response);
        }

        /// <summary>
        /// Update Configuration
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cardConfigurationFilter"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        public async Task<IActionResult> Put(string id, [FromBody] CardConfigurationFilter cardConfigurationFilter)
        {
            if (cardConfigurationFilter == null)
            {
                return BadRequest();
            }

            var response = await _cardManager.UpdateCardConfiguration(cardConfigurationFilter);

            if (response == null)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Delete(string id, [FromBody] ControlDeleteRequest entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }

            var response = await _cardManager.DeleteCardConfiguration(entity);

            if (response == null || !response.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}