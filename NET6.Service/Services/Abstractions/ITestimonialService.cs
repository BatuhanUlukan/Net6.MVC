
using NET6.Entity.DTOs.Testimonials;

namespace NET6.Service.Services.Abstractions
{
    public interface ITestimonialService
    {
        Task<List<TestimonialDto>> GetAllTestimonialsNonDeletedAsync();
        Task<List<TestimonialDto>> GetAllTestimonialsDeletedAsync();
        Task<TestimonialDto> GetTestimonialNonDeletedAsync(Guid testimonialId);
        Task CreateTestimonialAsync(TestimonialAddDto testimonialAddDto);
        Task<string> UpdateTestimonialAsync(TestimonialUpdateDto testimonialUpdateDto);
        Task<string> SafeDeleteTestimonialAsync(Guid testimonialId);
        Task<string> UndoDeleteTestimonialAsync(Guid testimonialId);
        Task<TestimonialListDto> GetAllByPagingAsync();


    }
}
