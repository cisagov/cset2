import { Component, OnInit, AfterViewChecked, AfterViewInit } from '@angular/core';
import { Title, DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { ReportService } from '../../services/report.service';


@Component({
  selector: 'app-acet-executive',
  templateUrl: './acet-executive.component.html',
  styleUrls: ['./acet-executive.component.scss']
})
export class AcetExecutiveComponent implements OnInit {
  response: any = null;
  mockDataAcetExecutive: any = {
    "information": {
      "Assessment_Name": "Manhattan Assessment",
      "Assessment_Date": "2020-09-19",
      "Assessor_Name": "Michael Jones"
    }
  };

  constructor(
    public reportSvc: ReportService,
    private titleService: Title,

  ) { }

  ngOnInit(): void {
    this.titleService.setTitle("Executive Report - ASET");
    // Here get report data
    // ToDo: Uncomment this and connect backend for report data
    //this.reportSvc.getReport('<ACET Endpoint>').subscribe(
    //  (r: any) => {
    //    this.response = r;
    //  },
    //  error => console.log('Executive report load Error: ' + (<Error>error).message)
    //);
    this.response = this.mockDataAcetExecutive;

  }

}
