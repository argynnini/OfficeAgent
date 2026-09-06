Imports OpenAI.Chat

' AgentSettings.AiProvider（2=OpenAI, 1=Groq）に応じたChatClientの組み立てを一箇所にまとめる
Public Module AiChatClientFactory

    Public Function CreateClient() As ChatClient
        If AgentSettings.AiProvider = 2 Then
            Return New ChatClient(AgentSettings.OPENAI_MODEL, AgentSettings.API_KEY)
        End If

        Dim groqOptions = New OpenAI.OpenAIClientOptions() With {
            .Endpoint = New Uri("https://api.groq.com/openai/v1")
        }
        Return New ChatClient(AgentSettings.GROQ_MODEL,
                               New System.ClientModel.ApiKeyCredential(AgentSettings.GROQ_API_KEY),
                               groqOptions)
    End Function

End Module
