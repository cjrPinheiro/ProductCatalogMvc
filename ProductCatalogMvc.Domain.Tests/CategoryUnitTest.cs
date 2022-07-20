using FluentAssertions;
using ProductCatalogMvc.Domain.Entities;
using ProductCatalogMvc.Domain.Validation;

namespace ProductCatalogMvc.Domain.Tests
{
    public class CategoryUnitTest
    {
        [Fact(DisplayName = "Create category with valid state")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");

            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create category with invalid id")]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-90, "Category Name");

            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid Id value");
        }

        [Fact(DisplayName = "Create category with short name")]
        public void CreateCategory_ShortName_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "Ca");

            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters");
        }

        [Fact(DisplayName = "Create category with missing name")]
        public void CreateCategory_MissingName_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, "");

            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name.Name is required");
        }

        [Fact(DisplayName = "Create category with null name")]
        public void CreateCategory_NullName_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, null);

            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name.Name is required");
        }
    }
}
