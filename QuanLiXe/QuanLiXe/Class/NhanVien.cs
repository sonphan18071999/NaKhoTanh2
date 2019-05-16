﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe
{
    class NhanVien
    {
        MY_DB mydb = new MY_DB();
        public bool insertNhanVien(string manv,string fname,string lname,string gender, DateTime bdate, string phone, 
            string address,string cmnd, MemoryStream ava,string type)
        {
            SqlCommand cmd = new SqlCommand("insert into NhanVien(MaNV,fName,lName,gender,Birthday,Phone,Address,Cmnd,Ava,type)" +
                "values (@makh,@fname,@lname,@gender,@bdate,@phone,@add,@cmnd,@ava,@type)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
            
        }
        //public DataTable searchNhanVien(string manv)
        //{
        //    SqlCommand cmd = new SqlCommand("select * from NhanVien where manv=@manv" + manv, mydb.getConnection);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;

        //}
        public DataTable getAllCus()
        {
            SqlCommand cmd = new SqlCommand("select *from NhanVien", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable searchNhanVien(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
    }
    

}
