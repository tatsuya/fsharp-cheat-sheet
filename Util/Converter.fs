﻿module Converter

open Microsoft.VisualBasic
open System
open System.Data
open System.Xml

type Record1 = { Field1 : string; Field2 : string; Field3 : string }

let toRadian degree = (Math.PI / 180.0) * degree
let toDegree radian = (180.0 / Math.PI) * radian

let trimXml (xml : string) =
    let xd = XmlDocument()
    xd.LoadXml(xml.Replace("&", "&amp;"))
    xd.OuterXml

let toListOfArray (dt: DataTable) =
    dt.AsEnumerable()
    |> Seq.map (fun dr -> dr.ItemArray)
    |> List.ofSeq

let toListOfRecord (dt: DataTable) =
    dt.AsEnumerable()
    |> Seq.map (fun dr ->
        let xs = dr.ItemArray |> Array.map string
        { Field1 = xs.[0]; Field2 = xs.[1]; Field3 = xs.[2]; })
    |> List.ofSeq

// https://msdn.microsoft.com/en-us/library/ms912047.aspx
let hankaku s = Strings.StrConv(s, VbStrConv.Narrow, 1041)