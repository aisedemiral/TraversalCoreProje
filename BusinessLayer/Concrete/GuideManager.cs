using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class GuideManager:IGuideService
{
    private IGuideDal _guideDal;

    public GuideManager(IGuideDal guideDal)
    {
        _guideDal = guideDal;
    }

    public void TAdd(Guide t)
    {
        _guideDal.Insert( t);
    }

    public void TDelete(Guide t)
    {
        _guideDal.Delete( t);
    }

    public void TUpdate(Guide t)
    {
        _guideDal.Update( t);
    }

    public List<Guide> TGetList()
    {
        return _guideDal.GetList();
    }

    public Guide TGetByID(int id)
    {
        return _guideDal.GetByID(id);
    }

    public void TChangeToTrueByGuide(int id)
    {
        _guideDal.ChangeToFalseByGuide(id);
    }

    public void TChangeToFalseByGuide(int id)
    {
        _guideDal.ChangeToTrueByGuide(id);
    }
}