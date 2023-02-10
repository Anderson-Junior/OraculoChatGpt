using OraculoChatGptApi.Models;
using System.Threading.Tasks;

namespace OraculoChatGptApi.Interfaces
{
    public interface IOpenAITextService
    {
        Task<OpenAIResponse> CompletePrompt(OpenAIRequest request);
    }
}
