﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotLib
{
    public sealed class Constants
    {

        /// <summary>
        /// Usage Specific Messages
        /// </summary>
        public static readonly string TITLE_HASSBOT =
                "HassBot";
        public static readonly string USAGE_TITLE =
                "Usage";
        public static readonly string USAGE_AFK =
                "`~afk <message>` or `~away <message>` or `~seen <username>`";
        public static readonly string USAGE_SEEN =
                "`~seen <username>`";
        public static readonly string USAGE_EIGHTBALL =
                "`~8ball <your question>`";
        public static readonly string USAGE_AS =
                "`~as @user #channel <your message>`";
        public static readonly string USAGE_BASE64 =
                "`~base64_encode <string to encode>` or `~base64_decode <string to decode>`";
        public static readonly string USAGE_BREAKINGCHANGES =
                "`~breaking_changes 82` gives you breaking changes for release 82.0 and it's minor releases";
        public static readonly string USAGE_COMMAND =
                "`~command add` or `~command refresh` to refresh commands";
        public static readonly string USAGE_C2F =
                "`~c2f <numeric value of temperature in celsius>`";
        public static readonly string USAGE_F2C =
                "`~f2c <numeric value of temperature in fahrenheit>`";
        public static readonly string USAGE_VIOLATION =
                "`~violation pardon @username` to pardon a user's violations.\n`~violation add @user <description of violation>` to add a new violation";
        public static readonly string USAGE_HEX2DEC =
                "`~hex2dec <decimal value>`";
        public static readonly string USAGE_DEC2HEX =
                "`~dec2hex <hex value>`";
        public static readonly string USAGE_BIN2DEC =
                "`~bin2dec <binary value>`";
        public static readonly string USAGE_DEC2BIN =
                "`~dec2bin <decimal value>`";
        public static readonly string USAGE_LOOKUP =
                "`~lookup <keyword> <@ optional user>`";
        public static readonly string USAGE_DEEPSEARCH =
                "`~deepsearch <keyword>`";
        public static readonly string USAGE_LMGTFY =
                "`~lmgtfy <google search string>`";
        public static readonly string USAGE_YAML2JSON =
                "`~yaml2json <yaml code>`";
        public static readonly string USAGE_JSON2YAML =
                "`~json2yaml <json code>`";
        public static readonly string USAGE_SUBSCRIBE =
                "`~subscribe <tag>` to subscribe\n`~subscribe list` to see all subscribed tags.";
        public static readonly string USAGE_UNSUBSCRIBE =
                "`~unsubscribe <tag>` to unsubscribe\n`~unsubscribe all` to clear everything!";
        public static readonly string USAGE_YAML =
                "Tente o seguinte:\n~yaml? \\`\\`\\`yaml\ncode\n\\`\\`\\`";

        /// <summary>
        /// Command Specific Messages
        /// </summary>
        public static readonly string SEEN_MESSAGE_FORMAT =
                "**{0} está ausente ** para {1} com uma mensagem: point_right: {2}";
        public static readonly string AWAY_MESSAGE_FORMAT =
                "{0} está ausente! {1} :wave:";
        public static readonly string ACCESS_DENIED =
                "Acesso negado";
        public static readonly string ACCESS_DENIED_MESSAGE =
                "Você não tem permissões para executar este comando. Por favor, entre em contato com @skalavala para ter acesso";
        public static readonly string COMMAND_TOTAL =
                "Existem `{0}` comando (s) personalizado (s) disponíveis. ";
        public static readonly string SUCCESS =
                "Sucesso!";
        public static readonly string COMMAND_SUCCESS_MESSAGE =
                "Vá em frente e execute o comando usando `~{0}`";
        public static readonly string TITLE_SUBSCRIBE =
                "inscrição";
        public static readonly string TITLE_UNSUBSCRIBE =
                "Unsubscribe";
        public static readonly string ERROR_NO_SUBSCRIPTIONS =
                "Você não tem nenhuma inscrição atualmente.";
        public static readonly string INFO_TAG_EXISTS =
                "The tag '{0}' is already in your subscription list.";
        public static readonly string INFO_SUBSCRIPTION_SUCCESS =
                "Subscribed to tag '{0}' successfully.";
        public static readonly string INFO_CURRENT_SUBSCRIPTIONS =
                "Your current subscriptions are: {0}";
        public static readonly string INFO_UNSUBSCRIBE_ALL_SUCCESS =
                "Successfully unsubscribed to all tags.";
        public static readonly string INFO_NOT_SUBSCRIBED =
                "You have not subscribed to '{0}'.";
        public static readonly string INFO_UNSUBSCRIBE_SUCCESS =
                "Successfully unsubscribed to '{0}'.";

        public static readonly string MAXLINELIMITMESSAGE =
            "Atenção !: Por favor, use <https://www.hastebin.com> para compartilhar o código que é mais do que 10-15 linhas. Você foi avisado, {0}!;";

        public static readonly string COMMAND_REFRESH_SUCCESSFUL =
                "Comandos, Sitemap e domínios bloqueados são recarregados e prontos para serem usados!";
        public static readonly string COMMAND_REFRESH_FAILED =
                "Falha ao atualizar os dados de pesquisa! entre em contato com @Tiago em https://github.com/tmarquespt";

        public static readonly string COMMAND_MESSAGE =
                "Gerencie os dados do Hassbot online em <https://github.com/awesome-automations/hassbot-data>. Certifique-se de executar o comando `~ refresh` depois de atualizar os dados online.";
        public static readonly string GOOD_YAML =
                "Isso é perfeitamente válido YAML!";
        public static readonly string INVALID_YAML =
                "Invalido YAML! Error: {1}";
        public static readonly string WELCOME_TITLE =
                "Bem-vindo";
        public static readonly string WELCOME_MESSAGE =
                "Bem-vindo ao {0} Canal Discord!";
        public static readonly string WELCOME_RULES_MESSAGE =
                "Por favor leia {0} \n";
        public static readonly string CODE_SHARING_MESSAGE =
                "Para compartilhar código, use <https://www.hastebin.com> \ nSe tiver menos de 10 linhas de código, ** certifique-se de que ele esteja formatado usando o formato abaixo:\n\\`\\`\\`yaml\ncode\n\\`\\`\\`\n";
        public static readonly string FORMAT_CODE =
                "Formata Código";
        public static readonly string LET_ME_GOOGLE =
                "Deixe-me Google para você...";
        public static readonly string BAN_MESSAGE =
                "Usuário ** {0} ** foi banido permanentemente por postar {1}.";
        public static readonly string ERROR_BLOCKED_URL =
                "{0} Sua mensagem foi excluída porque contém um link ou um nome de domínio '{1}' que está na lista de bloqueados devido a: '** {2} **'. \ NPor favor, refaça a postagem removendo / alterando o nome de domínio / link. Sua mensagem original foi enviada para você.";
        public static readonly string USER_MESSAGE_BLOCKED_URL =
                "Aqui está sua mensagem original que você postou anteriormente que foi bloqueada. Você pode postar novamente removendo / alterando o nome de domínio / link: {0} \ nReason para exclusão: ** {1} ** \ nSua mensagem: {2}";

        /// <summary>
        /// Emojis
        /// </summary>
        public static readonly string EMOJI_INFORMATION =
                ":information_source:";
        public static readonly string EMOJI_STOPSIGN =
                ":octagonal_sign:";
        public static readonly string EMOJI_THUMBSUP =
                ":thumbsup:";
        public static readonly string EMOJI_THUMBSDOWN =
                ":thumbsdown:";
        public static readonly string EMOJI_THERMOMETER =
                ":thermometer:";
        public static readonly string EMOJI_NAMASTE =
                ":pray:";
        public static readonly string EMOJI_POINT_UP =
                ":point_up:";
        public static readonly string EMOJI_POINT_DOWN =
                ":point_down:";
        public static readonly string EMOJI_FAIL =
                ":cold_sweat:";
        public static readonly string EMOJI_GO =
                ":checkered_flag:";
        public static readonly string EMOJI_PING_PONG =
                ":ping_pong:";
    }
}
