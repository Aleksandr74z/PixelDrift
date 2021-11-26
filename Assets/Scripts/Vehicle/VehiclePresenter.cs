
public class VehiclePresenter
{
    private VehicleView _vehicleView;
    private VehicleModel _vehicleModel;
 
   public VehiclePresenter(VehicleView view, VehicleModel model)
    {
        _vehicleView = view;
        _vehicleModel = model;
    }
}