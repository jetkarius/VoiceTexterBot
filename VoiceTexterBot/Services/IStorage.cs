using VoiceTexterBot.Models;
using VoiceTexterBot.Configuration;

namespace VoiceTexterBot.Services
{
    public interface IStorage
    {
        /// <summary>
        /// Получение сессии пользователя по идентификатору
        /// </summary>
        Session GetSession(long chatId);
    }
}