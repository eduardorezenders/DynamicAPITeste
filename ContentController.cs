﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DynamicAPI.Model;

namespace DynamicAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostContent(RequisicaoModel _requisicao)
        {
            dynamic jsonStr = JsonConvert.SerializeObject(_requisicao.ConteudoEntrada.Conteudo);
            dynamic conteudo = JsonConvert.DeserializeObject<ExpandoObject>(jsonStr);

            /*foreach (var item in conteudo)
            {
                JObject c = new JObject();

                if (item["NomePessoa"] != null)
                {
                    foreach (var i in item)
                        c.Add(i);

                    Arquivar.SalvarPessoa(c);
                }
                else if (item["NomeSetor"] != null)
                {
                    foreach (var i in item)
                        c.Add(i);

                    Arquivar.SalvarSetor(c);
                }
                else if (item["NomeEmpresa"] != null)
                {
                    foreach (var i in item)
                        c.Add(i);

                    Arquivar.SalvarEmpresa(c);
                }
                else
                {
                    return BadRequest(conteudo);
                }
            }*/

            return Ok(conteudo);
        }
    }
}
