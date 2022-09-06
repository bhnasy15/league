
namespace Common
{
	using System;
	using System.Threading.Tasks;
	using System.Collections.Generic;
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using FluentValidation;

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TViewModel> : ControllerBase
        where TEntity : BaseEntity
        where TViewModel : BaseEntityViewModel
    {
        protected readonly IBaseUnitOfWork<TEntity> _baseUnitOfWork;
        protected readonly IMapper _mapper;
        protected readonly IValidator<TViewModel> _validator;

        public BaseController(IBaseUnitOfWork<TEntity> unitOfWork, IMapper mapper, IValidator<TViewModel> validator)
        {
            _baseUnitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TViewModel>>> Get()
        {
			var entities = await _baseUnitOfWork.ReadAsync();
			return Ok(entities.Select(e =>
					_mapper.Map<TViewModel>(e)));
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entity = await _baseUnitOfWork.ReadByIdAsync(id);

			TViewModel viewModel =
				_mapper.Map<TViewModel>(entity);

			FluentValidation.Results.ValidationResult validationResult = await
				new BaseValidator<TViewModel>().ValidateAsync(viewModel);

            if (!validationResult.IsValid)
                return BadRequest(new { errors = validationResult.Errors });

            return Ok(viewModel);
        }

        // POST api/<ProductsController>
		[Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<TViewModel>> Post([FromBody] TEntity entity)
        {
            var ent = await _baseUnitOfWork.CreateAsync(entity);
            return Created(entity.Id.ToString(), _mapper.Map<TViewModel>(ent));
        }

        // PUT api/<entitysController>/5
		[Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<ActionResult<TViewModel>> Put([FromBody] TEntity entity)
        {
            var ent = await _baseUnitOfWork.UpdateAsync(entity);
            return Created(entity.Id.ToString(), _mapper.Map<TViewModel>(ent));
        }

        // DELETE api/<entitysController>/5
		[Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _baseUnitOfWork.DeleteAsync(id);
        }
    }
}
