import { Component, OnInit, ViewChild, OnDestroy } from '@angular/core';
import { MatSidenav } from '@angular/material/sidenav';
import { StatusSidenavService } from '@services/statusSidenav/status-sidenav.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss'],
})
export class SidenavComponent implements OnInit, OnDestroy {
  @ViewChild('sidenav', { static: true }) sidenav: MatSidenav;
  readonly UnSubscribe$: Subject<void> = new Subject<void>();
  listMenu = [];

  constructor(private _statusSidenavService: StatusSidenavService) {}

  ngOnInit(): void {
    this._statusSidenav();
  }

  ngOnDestroy(): void {
    this.UnSubscribe$.next();
    this.UnSubscribe$.complete();
  }

  private _statusSidenav() {
    const { _statusSidenavService, UnSubscribe$ } = this;
    _statusSidenavService
      .status()
      .pipe(takeUntil(UnSubscribe$))
      .subscribe(() => {
        this.sidenav.toggle();
      });
  }

  closeSidenav() {
    this.sidenav.toggle();
  }
}
