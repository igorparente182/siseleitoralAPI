using siseleitoralAPI.Models;
using siseleitoralAPI.Repositories;
using siseleitoralAPI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siseleitoralAPI.Services
{
    public class ConsultaGeralService : IConsultaGeralService
    {
        private readonly IConsultaGeralRepository _consultaGeral;

        public ConsultaGeralService(IConsultaGeralRepository consultaGeral)
        {
            _consultaGeral = consultaGeral;
        }
        public async Task<GenericResult> GetConsultaGerals(string value)
        {
            var result = new GenericResult();

            try
            {                
                var list = await _consultaGeral.GetConsultaGerals(value);
                if (list != null && list.Count>0)
                {
                    result.Data = list;
                    result.Success = true;
                    result.Menssage = "Sucesso";
                    return result;
                }
                result.Data = null;
                result.Success = false;
                result.Menssage = "Não foi encontrado nenhum resultado";
                return result;

            }catch(Exception e)
            {
                result.Data = null;
                result.Success = false;
                result.Menssage = "Erro de "+e.Message;
                return result;
            }
        }

        public async Task<GenericResult> GetConsultasContato(int zona, int codMun, int codLoc)
        {
            var result = new GenericResult();

            try
            {
                var list = await _consultaGeral.GetConsultasContato(zona,codMun,codLoc);
                if (list != null && list.Count > 0)
                {
                    result.Data = list;
                    result.Success = true;
                    result.Menssage = "Sucesso";
                    return result;
                }
                result.Data = null;
                result.Success = false;
                result.Menssage = "Não foi encontrado nenhum resultado";
                return result;

            }
            catch (Exception e)
            {
                result.Data = null;
                result.Success = false;
                result.Menssage = "Erro de " + e.Message;
                return result;
            }
        }
    }
}
