﻿
using System.Collections.Generic;
using System.Collections.Generic;

namespace BiddingApp.DataAccess.Contracts
{
    public interface IRepository<TModel> where TModel : class
    {
        /// <summary>
        ///     Получает все вхождения из базы данных
        /// </summary>
        ICollection<TModel> GetAll();

        /// <summary>
        ///     Получает вхождение с указанным id
        /// </summary>
        TModel Get(int id);

        /// <summary>
        ///     Вносит указанный объект в базу данных
        /// </summary>
        void Create(TModel item);

        /// <summary>
        ///     Изменяет указанный объект в базе данных
        /// </summary>
        void Update(TModel item);

        /// <summary>
        ///     Удаляет указанный объект из базы данных
        /// </summary>
        void Delete(TModel item);
    }
}

