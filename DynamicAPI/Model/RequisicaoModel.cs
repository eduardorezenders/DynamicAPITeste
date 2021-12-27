using System;
using System.Collections.Generic;

namespace DynamicAPI.Model
{
    public class RequisicaoModel
    {
        public string Id { get; set; }
        public string ClienteId { get; set; }
        public string Cliente { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Webhook { get; set; }
        public string Status { get; set; }
        public RequisicaoDataModel ConteudoEntrada { get; set; }
        public RequisicaoDataModel ConteudoRetorno { get; set; }
        public RequisicaoAutenticacaoModel Autenticacao { get; set; }
        public IList<RequisicaoAutenticacaoModel> Autenticacoes { get; set; }
    }
}
