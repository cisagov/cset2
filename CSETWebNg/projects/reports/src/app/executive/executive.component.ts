////////////////////////////////
//
//   Copyright 2019 Battelle Energy Alliance, LLC
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
//
////////////////////////////////
import { Component, OnInit, AfterViewInit } from '@angular/core';
import { AnalysisService } from '../services/analysis.service';
import { ReportService } from '../services/report.service';
import { Title } from '@angular/platform-browser';
import { AcetDashboard } from '../../../../../src/app/models/acet-dashboard.model';
import { ACETService } from '../../../../../src/app/services/acet.service';


@Component({
  selector: 'rapp-executive',
  templateUrl: './executive.component.html',
  styleUrls: ['./executive.component.scss'
  ]
})
export class ExecutiveComponent implements OnInit, AfterViewInit {
  response: any;

  chartPercentCompliance: Chart;
  chartStandardsSummary: Chart;
  chartStandardResultsByCategory: Chart;
  responseResultsByCategory: any;


  dummyChart1: Chart;
  dummyChart2: Chart;

  acetDashboard: AcetDashboard;


  constructor(
    public reportSvc: ReportService,
    private analysisSvc: AnalysisService,
    private titleService: Title,
    public acetSvc: ACETService
  ) { }

  ngOnInit() {
    this.titleService.setTitle("Executive Summary - CSET");

    this.reportSvc.getReport('executive').subscribe(
      (r: any) => {
        this.response = r;
      },
      error => console.log('Executive report load Error: ' + (<Error>error).message)
    );

    this.reportSvc.getACET().subscribe((x: boolean) => {
      this.reportSvc.hasACET = x;
    });



    this.doChartStuff();



  }

  ngAfterViewInit() {

    // Populate charts
    this.analysisSvc.getDashboard().subscribe(x => {
      this.chartPercentCompliance = this.analysisSvc.buildPercentComplianceChart('canvasCompliance', x);
    });

    this.analysisSvc.getStandardsSummaryOverall().subscribe(x => {
      this.chartStandardsSummary = this.analysisSvc.buildStandardsSummary('canvasStandardsSummary', x);
    });

    this.analysisSvc.getStandardsResultsByCategory().subscribe(x => {
      this.responseResultsByCategory = x;
      this.chartStandardResultsByCategory = this.analysisSvc.buildStandardResultsByCategoryChart('chartStandardResultsByCategory', x);
    });


    // This is an attempt at making a horizontal stacked bar chart using Chart.js
    // this.dummyChart1 = this.analysisSvc.buildDummyComponentAnswerPie('canvasComponentSummary');
    this.dummyChart2 = this.analysisSvc.buildDummyComponentChart1('chartNetwork1');


    // ACET-specific content
    this.acetSvc.getAcetDashboard().subscribe(
      (data: AcetDashboard) => {
        this.acetDashboard = data;

        for (let i = 0; i < this.acetDashboard.IRPs.length; i++) {
          this.acetDashboard.IRPs[i].Comment = this.acetSvc.interpretRiskLevel(this.acetDashboard.IRPs[i].RiskLevel);
        }
      },
      error => {
        console.log('Error getting all documents: ' + (<Error>error).name + (<Error>error).message);
        console.log('Error getting all documents: ' + (<Error>error).stack);
      });
  }

// var chart = new CanvasJS.Chart("chartContainer2",
//     {
//         animationEnabled: true,
//         title: {
//             text: "Combined Component Summary",
// 			backgroundColor: '#367190',
// 			fontFamily: 'Verdana',
// 			fontColor: 'white',
// 			fontSize: 16,
// 			padding: 7,
//         },
//         data: [
//         {
//             type: "pie",
//             showInLegend: true,
//             dataPoints: [
//                 { y: 75, legendText: "Yes", color: "#006000"},
//                 { y: 10, legendText: "No", color: "#990000"},
//                 { y: 5, legendText: "N/A", color: "rgb(0, 94, 166)"},
//                 { y: 5, legendText: "Alternate", color: "#F9CE15"},
//                 { y: 5, legendText: "Unanswered", color: "#bfbfbf"}
//             ]
//         },
//         ]
//     });
// chart.render();

// var chart = new CanvasJS.Chart("chartContainer4",
//     {
//         animationEnabled: true,
//         title: {
//             text: ""
//         },
//         axisX: {
//             interval: 10,
//         },
//         data: [
//         {
//             type: "stackedBar",
//             color: '#006000',
//             showInLegend: false,
// 			label: 'Yes',
// 			fontFamily: 'Verdana',
// 			fontSize: '16',
//             dataPoints: [
//                 { x: 160, y: 75, label: "Active Directory" },
//                 { x: 150, y: 75, label: "DB Server" },
//                 { x: 140, y: 75, label: "Firewall" },
//                 { x: 130, y: 75, label: "Handheld Wireless Device" },
//                 { x: 120, y: 75, label: "HMI" },
//                 { x: 110, y: 75, label: "IDS" },
//                 { x: 100, y: 75, label: "IP Camera" },
//                 { x: 90, y: 75, label: "IP Phone" },
// 			        	{ x: 80, y: 75, label: "Network Printer" },
// 			        	{ x: 70, y: 75, label: "Optical Ring" },
// 			        	{ x: 60, y: 75, label: "RAS" },
// 			        	{ x: 50, y: 75, label: "Router" },
// 			         	{ x: 40, y: 75, label: "Server" },
// 			        	{ x: 30, y: 75, label: "Switch" },
// 			        	{ x: 20, y: 75, label: "Terminal Server" },
// 			        	{ x: 10, y: 75, label: "Wireless Modem" }
//             ]
//         }, {
//             type: "stackedBar",
//             color: '#990000',
//             showInLegend: false,
// 			label: 'No',
//             dataPoints: [
//                 { x: 160, y: 10, label: "Active Directory" },
//                 { x: 150, y: 10, label: "DB Server" },
//                 { x: 140, y: 10, label: "Firewall" },
//                 { x: 130, y: 10, label: "Handheld Wireless Device" },
//                 { x: 120, y: 10, label: "HMI" },
//                 { x: 110, y: 10, label: "IDS" },
//                 { x: 100, y: 10, label: "IP Camera" },
//                 { x: 90, y: 10, label: "IP Phone" },
// 			        	{ x: 80, y: 10, label: "Network Printer" },
// 			        	{ x: 70, y: 10, label: "Optical Ring" },
// 			        	{ x: 60, y: 10, label: "RAS" },
// 			        	{ x: 50, y: 10, label: "Router" },
// 			        	{ x: 40, y: 10, label: "Server" },
// 			        	{ x: 30, y: 10, label: "Switch" },
// 			        	{ x: 20, y: 10, label: "Terminal Server" },
// 			        	{ x: 10, y: 10, label: "Wireless Modem" }
//             ]
//         }, {
//             type: "stackedBar",
//             color: 'rgb(0, 94, 166)',
//             showInLegend: false,
// 			label: 'N/A',
//             dataPoints: [
//                 { x: 160, y: 5, label: "Active Directory" },
//                 { x: 150, y: 5, label: "DB Server" },
//                 { x: 140, y: 5, label: "Firewall" },
//                 { x: 130, y: 5, label: "Handheld Wireless Device" },
//                 { x: 120, y: 5, label: "HMI" },
//                 { x: 110, y: 5, label: "IDS" },
//                 { x: 100, y: 5, label: "IP Camera" },
//                 { x: 90, y: 5, label: "IP Phone" },
// 			        	{ x: 80, y: 5, label: "Network Printer" },
// 			        	{ x: 70, y: 5, label: "Optical Ring" },
// 			        	{ x: 60, y: 5, label: "RAS" },
// 			        	{ x: 50, y: 5, label: "Router" },
// 			         	{ x: 40, y: 5, label: "Server" },
// 			        	{ x: 30, y: 5, label: "Switch" },
// 			        	{ x: 20, y: 5, label: "Terminal Server" },
// 			        	{ x: 10, y: 5, label: "Wireless Modem" }
//             ]
//         }, {
//             type: "stackedBar",
//             color: '#F9CE15',
//             showInLegend: false,
// 			label: 'Alternate',
//             dataPoints: [
//                 { x: 160, y: 5, label: "Active Directory" },
//                 { x: 150, y: 5, label: "DB Server" },
//                 { x: 140, y: 5, label: "Firewall" },
//                 { x: 130, y: 5, label: "Handheld Wireless Device" },
//                 { x: 120, y: 5, label: "HMI" },
//                 { x: 110, y: 5, label: "IDS" },
//                 { x: 100, y: 5, label: "IP Camera" },
//                 { x: 90, y: 5, label: "IP Phone" },
// 			        	{ x: 80, y: 5, label: "Network Printer" },
// 			        	{ x: 70, y: 5, label: "Optical Ring" },
// 			        	{ x: 60, y: 5, label: "RAS" },
// 			        	{ x: 50, y: 5, label: "Router" },
// 			        	{ x: 40, y: 5, label: "Server" },
// 			        	{ x: 30, y: 5, label: "Switch" },
// 			        	{ x: 20, y: 5, label: "Terminal Server" },
// 			        	{ x: 10, y: 5, label: "Wireless Modem" }
//             ]
//         }, {
//             type: "stackedBar",
//             color: '#bfbfbf',
//             showInLegend: false,
// 			label: 'Unanswered',
//             dataPoints: [
//                 { x: 160, y: 5, label: "Active Directory" },
//                 { x: 150, y: 5, label: "DB Server" },
//                 { x: 140, y: 5, label: "Firewall" },
//                 { x: 130, y: 5, label: "Handheld Wireless Device" },
//                 { x: 120, y: 5, label: "HMI" },
//                 { x: 110, y: 5, label: "IDS" },
//                 { x: 100, y: 5, label: "IP Camera" },
//                 { x: 90, y: 5, label: "IP Phone" },
// 			        	{ x: 80, y: 5, label: "Network Printer" },
// 			        	{ x: 70, y: 5, label: "Optical Ring" },
// 			        	{ x: 60, y: 5, label: "RAS" },
// 			        	{ x: 50, y: 5, label: "Router" },
// 			        	{ x: 40, y: 5, label: "Server" },
// 			        	{ x: 30, y: 5, label: "Switch" },
// 			        	{ x: 20, y: 5, label: "Terminal Server" },
// 			        	{ x: 10, y: 5, label: "Wireless Modem" }
//             ]
//         }
//         ]
//     });
// chart.render();

