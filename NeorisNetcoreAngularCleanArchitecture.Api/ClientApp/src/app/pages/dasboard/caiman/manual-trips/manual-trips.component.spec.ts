import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManualTripsComponent } from './manual-trips.component';

describe('ManualTripsComponent', () => {
  let component: ManualTripsComponent;
  let fixture: ComponentFixture<ManualTripsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManualTripsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManualTripsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
