using OraculoChatGpt.Models;
using System.Threading.Tasks;

namespace OraculoChatGpt.Interfaces
{
    public interface IOpenAITextService
    {
        Task<OpenAIResponse> CompletePrompt(OpenAIRequest request);
    }
}
